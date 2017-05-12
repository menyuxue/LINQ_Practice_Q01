<Query Kind="Statements">
  <Connection>
    <ID>5afb1b74-90cd-4c9d-96bc-097c981e6915</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results= from a in Artists
             where a.ArtistId==1
             orderby a.Name
			 select new
			 {
			   Artist = a.Name,
			   Albums = from  t in a.Albums
			            orderby t.Title
			            select new
				{
				    Title = t.Title,
					Tracks = from tr in t.Tracks
					         select new
					{
					    TrackName= tr.Name,
						GenreId = tr. GenreId,
						MediaType = tr.Genre.Name,
						Composer=tr.Composer,
						Milliseconds=tr.Milliseconds
					}
				}
			   };
results.Dump();