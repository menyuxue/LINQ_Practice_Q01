<Query Kind="Statements">
  <Connection>
    <ID>5afb1b74-90cd-4c9d-96bc-097c981e6915</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results= from a in MediaTypes
            select new
			{
			Name =a.Name,
			Tracks =from t in a.Tracks
			         select new
				{
				TrackName= t.Name,
				Album= t.Album.Title,
				Artist = t.Album.Artist.Name,
				ReleaseYear = t.Album.ReleaseYear,
				ReleaseLabel= t.Album.ReleaseLabel,
				Genre= t.Genre.Name
				}
			};
results.Dump();