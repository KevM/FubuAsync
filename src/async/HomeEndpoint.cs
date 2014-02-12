using HtmlTags;

namespace async
{
	public class HomeEndpoint
	{

		public HtmlDocument Index()
		{
			var htmlDocument = new HtmlDocument();
			htmlDocument.Add(new HtmlTag("h1", t => t.Text("Hola")));
			return htmlDocument;
		}
	}
}