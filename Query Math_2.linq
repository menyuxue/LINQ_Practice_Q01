<Query Kind="Statements">
  <Connection>
    <ID>5afb1b74-90cd-4c9d-96bc-097c981e6915</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
             where g.Name.Equals("Heavy Metal")
			  select new
			  { 
			   TracksCount = g.Tracks.Count(),
			   Tracks = from t in g.Tracks
			            select new
				{
				    TrackName = t.Name,
				    AlbumName = t.Album.Title,
					Milliseconds=t.Milliseconds,
					size = (t.Bytes/100)+"kb",
					Price = t.UnitPrice
				}
			   };
results.Dump("Heavy Metal");