# Resolver Issue

## To Reproduce
1. Start the database (docker-compose build postgres && docker-compose up postgres)  
1. Run GraphQLService  
1. http://localhost:5000/graphql
1. Run in BCP: query{trackers {id name}}
1. All id values are 0
1. Comment-out `[IsProjected(true)] public int Id { get; set; } ` in GraphQLService/GraphQL/TrackerResolver.cs
1. Run in BCP: query{trackers {id name}}
1. All id values are non-zero (1, 2, 3)

## Scaffold
Run from ./GraphQLService  

`dotnet-ef dbcontext scaffold "host=localhost;port=20202;username=postgres;password=postgres;database=test" Npgsql.EntityFrameworkCore.PostgreSQL -o TestDb -c TestDbContext`  
