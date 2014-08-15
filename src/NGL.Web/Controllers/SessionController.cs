﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using NGL.Web.Data.Entities;
using NGL.Web.Data.Infrastructure;
using NGL.Web.Infrastructure.Security;
using NGL.Web.Models;
using NGL.Web.Models.Session;

namespace NGL.Web.Controllers
{
    public partial class SessionController : Controller
    {
        private readonly IGenericRepository _genericRepository;
        private readonly IMapper<CreateModel, Session> _createModelToEntityMapper;
        private readonly IMapper<Session, IndexModel> _entityToIndexModelMapper;

        public SessionController(IGenericRepository genericRepository, 
            IMapper<CreateModel, Session> createModelToEntityMapper, 
            IMapper<Session, IndexModel> entityToIndexModelMapper)
        {
            _genericRepository = genericRepository;
            _createModelToEntityMapper = createModelToEntityMapper;
            _entityToIndexModelMapper = entityToIndexModelMapper;
        }

        [AuthorizeFor(Resource = "session", Operation = "view")]
        public virtual ActionResult Index()
        {
            IEnumerable<Session> sessions = _genericRepository.GetAll<Session>().ToList();
            var indexModels = new List<IndexModel>();

            foreach (var session in sessions)
            {
                var indexModel = new IndexModel();
                _entityToIndexModelMapper.Map(session, indexModel);
                indexModels.Add(indexModel);
            }
            return View(indexModels);
        }

        // GET: Session
        [AuthorizeFor(Resource = "session", Operation = "create")]
        public virtual ActionResult Create()
        {
            return View(new CreateModel());
        }

        [HttpPost]
        [AuthorizeFor(Resource = "session", Operation = "create")]
        public virtual ActionResult Create(CreateModel createModel)
        {
            if (!ModelState.IsValid)
                return View(createModel);

            var session = new Session();
            _createModelToEntityMapper.Map(createModel, session);
            _genericRepository.Add(session);
            _genericRepository.Save();

            return RedirectToAction(Actions.Index());
        }
    }
}