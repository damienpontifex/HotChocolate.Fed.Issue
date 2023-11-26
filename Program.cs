using ApolloGraphQL.HotChocolate.Federation.Two;
using HotChocolate.Fed.Issue;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
    // .AddApolloFederation()
    .AddApolloFederationV2(schemaConfiguration: schema =>
    {
        schema.Contact(
            name: "<value>",
            url: "<value>",
            description: "<value>"
        );
    })
    .AddDirectiveType<ContactDirectiveType>()
    .AddQueryType<Query>()
    .AddDirectiveType<RequiresScopesDirectiveType>()
    .AddAuthorization()
    .AddInstrumentation(o => o.RenameRootActivity = true)
    .InitializeOnStartup();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
