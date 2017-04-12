// ...
private IQueryable<BaseSearchResultItem> ApplyManufacturerQuery(IQueryable<BaseSearchResultItem> query, PhoneSearchParam searchParam)
{
    /*
    query.AsEnumerable()
        .Select(phone => { (string)phone["manufacture"].ToLower() == searchParam.Manufacture.ToLower() });
    */

    query = query.Where( (phone) => phone["manufacturer"] == searchParam.Manufacture  );
    return query;
}

// ...