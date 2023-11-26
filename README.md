Schema generated by `dotnet run -- schema export --output my-schema.graphql `

Studio configured with Federation 2.5 and publish by
```bash
APOLLO_KEY=<key-here> \
  rover subgraph publish graph@ref \
  --schema ./my-schema.graphql \
  --name myapi \
  --routing-url http://my-api:8080/graphql
```

Errors observed
```
WARN: The following build errors occurred:
DIRECTIVE_DEFINITION_INVALID: [myapi] Invalid definition for directive "@key": argument "fields" should have type "_FieldSet!" but found type "FieldSet!"
DIRECTIVE_DEFINITION_INVALID: [myapi] Invalid definition for directive "@requires": argument "fields" should have type "_FieldSet!" but found type "FieldSet!"
DIRECTIVE_DEFINITION_INVALID: [myapi] Invalid definition for directive "@provides": argument "fields" should have type "_FieldSet!" but found type "FieldSet!"
```