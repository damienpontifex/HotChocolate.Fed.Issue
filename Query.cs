using ApolloGraphQL.HotChocolate.Federation;

namespace HotChocolate.Fed.Issue;

public class Query
{
		[RequiresScopes(["sid"])]
	  public Product Product([ID] string id)
		{
				return new() { Id = id };
		}
}

[Key("id")]
public class Product
{
		[ID]
		public string Id { get; set; } = default!;
}