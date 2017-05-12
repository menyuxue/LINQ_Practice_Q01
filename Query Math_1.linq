<Query Kind="Statements">
  <Connection>
    <ID>5afb1b74-90cd-4c9d-96bc-097c981e6915</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              orderby g.Name
			  select new
			  {
			   Genre = g.Name,
			   TracksCount = g.Tracks.Count()
			   };
results.Dump("Query Math");