
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedTouch.Core;
using MedTouch.Common;
using MedTouch.ContentSearch.Search;
using MedTouch.StayWell.layouts.modules.StayWell.Default;

using nhrmc.org.BusinessLogic.Feature_Cards;

using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Rules;
using Sitecore.ContentSearch.Utilities;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Search;

//using nhrmc.org.Website.WebApi;

[assembly: MRegisterApiController(typeof(nhrmc.org.Website.WebApi.FeatureCardByTaxonomy))]
namespace nhrmc.org.Website.WebApi {
    public class FeatureCardByTaxonomy : MApiController, IMApiGetAction
    {

        public virtual string Get(MApiArgs arguments)
        {
            try
            {
                string contentIdStr = arguments.QueryString["contentIds"];
                string abc = arguments.QueryString["abc"];
                return this.Json("OK"); 
            } catch (Exception e) {
                return this.BadRequest(e.Message);
            }
        }
    }
}