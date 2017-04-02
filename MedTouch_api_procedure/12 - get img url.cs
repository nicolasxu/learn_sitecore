FileField fileField = taxonomy.Fields["Taxonomy Image"];
return fileField.MediaItem.IsNotNull()
          ? Sitecore.Resources.Media.MediaManager.GetMediaUrl(fileField.MediaItem)
          : string.Empty;