﻿using AvaloniaMusicStore.Models;

namespace AvaloniaMusicStore.ViewModels;

public class AlbumViewModel : ViewModelBase
{
   private readonly Album _album;

   public AlbumViewModel(Album album)
   {
      _album = album;
   }

   public string Artist => _album.Artist;
   public string Title => _album.Title;
}
