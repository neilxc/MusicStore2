interface IAlbum {
  id: number;
  title?: string;
  price?: number;
  albumArtUrl?: string;
  genre?: IGenre;
  artist?: IArtist;
}
