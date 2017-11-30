using Abp.Web.Mvc.Views;

namespace LeKin.Web.Views
{
    public abstract class LeKinWebViewPageBase : LeKinWebViewPageBase<dynamic>
    {

    }

    public abstract class LeKinWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected LeKinWebViewPageBase()
        {
            LocalizationSourceName = LeKinConsts.LocalizationSourceName;
        }
    }
}