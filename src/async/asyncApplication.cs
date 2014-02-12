using FubuMVC.Core;
using FubuMVC.StructureMap;
using StructureMap;

namespace async
{
	public class asyncApplication : IApplicationSource
	{
	    public FubuApplication BuildApplication()
	    {
            return FubuApplication.For<asyncFubuRegistry>()
				.StructureMap<asyncRegistry>();
	    }
	}
}