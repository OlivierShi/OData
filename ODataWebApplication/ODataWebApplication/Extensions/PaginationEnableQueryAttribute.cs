using Microsoft.AspNetCore.OData.Query;

namespace ODataWebApplication.Extensions
{
    public class PaginationEnableQueryAttribute : EnableQueryAttribute
    {
        private const string PreferHeaderName = "Prefer";
        private const string ODataMaxPageSizePreferenceToken = "odata.maxpagesize";
        public const int DefaultMaxPageSize = 1;

        public override IQueryable ApplyQuery(IQueryable queryable, ODataQueryOptions queryOptions)
        {
            string preferences = queryOptions.Request.Headers[PreferHeaderName];

            base.PageSize = GetPreferMaxPageSize(preferences);
            return base.ApplyQuery(queryable, queryOptions);
        }

        private int GetPreferMaxPageSize(string preferences)
        {
            int pageSize = DefaultMaxPageSize;

            Dictionary<string, string> keyValuePairs = preferences.Split(',')
                .Select(value => value.Split('='))
                .ToDictionary(pair => pair[0], pair => pair[1]);
            var preferenceList = preferences.Split(',');
            if (keyValuePairs.ContainsKey(ODataMaxPageSizePreferenceToken))
            {
                pageSize = int.Parse(keyValuePairs[ODataMaxPageSizePreferenceToken]);
            }
 
            return pageSize;
        } 
    }
}
