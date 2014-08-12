﻿using NGL.Tests.Builders;
using NGL.Web.Models.Assessment;
using Shouldly;
using Xunit;

namespace NGL.Tests.Assessment
{
    public class AssessmentToAssessmentIndexModelMapperTests
    {
        [Fact]
        public void ShouldMapAssessmentToIndexModelMapper()
        {
            var mapper = new AssessmentToAssessmentIndexModelMapper();
            Web.Data.Entities.Assessment assessment = new AssessmentBuilder().Build();
            var section = new SectionBuilder().WithAssessment(assessment).Build();
            
            var indexModel = mapper.Build(assessment);

            indexModel.AssessmentTitle.ShouldBe("My Assessment");
            indexModel.SessionName.ShouldBe("Fall 2014");
            indexModel.SectionName.ShouldBe("CHEM2090 - 200");
//            indexModel.CCSS.ShouldBe("blah"); TODO
            indexModel.Date.ShouldBe("1/1/0001");
            indexModel.id.ShouldBe(1);
        }
    }
}
