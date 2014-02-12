using System.Threading.Tasks;
using FubuMVC.Core.Ajax;

namespace async
{
	public class AsyncEndpoint
	{
		//hit http://localhost:49886/async/decision as many times as you like and it works fine
		public Task<AsycResult> post_async_Decide(AsyncRequest request)
		{
			return Task<AsycResult>.Factory.StartNew(() => new AsycResult {Success = true, Target = request.Decide});
		}
		
		public class AsyncRequest
		{
			public string Decide { get; set; }
		}

		public class AsycResult
		{
			public bool Success { get; set; }
			public object Target { get; set; }
		}

		//hit http://localhost:49886/continuation/decision once. And it works. Hit it again:
/*
[ArgumentException: An item with the same key has already been added.]
System.ThrowHelper.ThrowArgumentException(ExceptionResource resource) +52
System.Collections.Generic.Dictionary`2.Insert(TKey key, TValue value, Boolean add) +11187358
System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value) +10
FubuCore.Util.Cache`2.Fill(TKey key, Func`2 onMissing) in c:\BuildAgent\work\4dafc5966c0aefb4\src\FubuCore\Util\Cache.cs:132
FubuMVC.Core.Runtime.FubuRequest.Get() in c:\BuildAgent\work\ae412c8ad89b884b\src\FubuMVC.Core\Runtime\FubuRequest.cs:23
  ... more elided
 */
		public Task<AjaxContinuation> post_continuation_Decide(ContinuationRequest request)
		{
			return Task<AjaxContinuation>.Factory.StartNew(() => new AjaxContinuation { Success = true, Message = request.Decide});
		}

		public class ContinuationRequest
		{
			public string Decide { get; set; }
		}

		public class ContinuationResult
		{
			public bool Success { get; set; }
			public object Target { get; set; }
		}
	}
}