


Item homeNode = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath);
var sitesettings = Sitecore.Context.Database.GetItem(homeNode.Fields["Site Settings"].ToString());
var startpath = Sitecore.Context.Database.GetItem(sitesettings.Fields["Feature Card Search Start Path"].Value);