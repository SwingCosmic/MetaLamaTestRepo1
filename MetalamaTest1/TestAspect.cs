using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using Metalama.Framework.Code.DeclarationBuilders;
using System.ComponentModel.DataAnnotations.Schema;
namespace MetalamaTest1
{
    public class TestAspect : TypeAspect
    {
        public override void BuildAspect(IAspectBuilder<INamedType> builder)
        {
            if (builder.Target.ImplementedInterfaces.Contains(typeof(IDetectInterface)))
            {
                var property = builder.Target.Properties.Single(p => p.Name == nameof(IDetectInterface.CreateTime));
                builder.Advice.IntroduceAttribute(
                    property,
                    AttributeConstruction.Create(
                        typeof(DatabaseGeneratedAttribute),
                        new object[] { DatabaseGeneratedOption.Identity }
                    ),
                    OverrideStrategy.Ignore
                );
            }
        }
    }
}