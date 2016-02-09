using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace AuthorizedActionLink
{
    public static class AuthorizedActionLinkHtmlHelper
    {
        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays specified text.
        /// </summary>
        /// <returns>Link or specified text.</returns>
        public static MvcHtmlString AuthorizedActionLinkOrText(this HtmlHelper htmlHelper, string linkText, string actionName)
        {
            return AuthorizedActionLinkOrText(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: null,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: null,
                htmlAttributes: null
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays specified text.
        /// </summary>
        /// <returns>Link or specified text.</returns>
        public static MvcHtmlString AuthorizedActionLinkOrText(this HtmlHelper htmlHelper, string linkText, string actionName, object routeValues)
        {
            return AuthorizedActionLinkOrText(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: null,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: new RouteValueDictionary(routeValues),
                htmlAttributes: null
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays specified text.
        /// </summary>
        /// <returns>Link or specified text.</returns>
        public static MvcHtmlString AuthorizedActionLinkOrText(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName)
        {
            return AuthorizedActionLinkOrText(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: controllerName,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: null,
                htmlAttributes: null
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays specified text.
        /// </summary>
        /// <returns>Link or specified text.</returns>
        public static MvcHtmlString AuthorizedActionLinkOrText(this HtmlHelper htmlHelper, string linkText, string actionName, RouteValueDictionary routeValues)
        {
            return AuthorizedActionLinkOrText(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: null,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: routeValues,
                htmlAttributes: null
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays specified text.
        /// </summary>
        /// <returns>Link or specified text.</returns>
        public static MvcHtmlString AuthorizedActionLinkOrText(this HtmlHelper htmlHelper, string linkText, string actionName, object routeValues, object htmlAttributes)
        {
            return AuthorizedActionLinkOrText(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: null,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: new RouteValueDictionary(routeValues),
                htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes)
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays specified text.
        /// </summary>
        /// <returns>Link or specified text.</returns>
        public static MvcHtmlString AuthorizedActionLinkOrText(this HtmlHelper htmlHelper, string linkText, string actionName, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
        {
            return AuthorizedActionLinkOrText(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: null,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: routeValues,
                htmlAttributes: htmlAttributes
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays specified text.
        /// </summary>
        /// <returns>Link or specified text.</returns>
        public static MvcHtmlString AuthorizedActionLinkOrText(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, object routeValues, object htmlAttributes)
        {
            return AuthorizedActionLinkOrText(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: controllerName,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: new RouteValueDictionary(routeValues),
                htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes)
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays specified text.
        /// </summary>
        /// <returns>Link or specified text.</returns>
        public static MvcHtmlString AuthorizedActionLinkOrText(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
        {
            return AuthorizedActionLinkOrText(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: controllerName,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: routeValues,
                htmlAttributes: htmlAttributes
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays specified text.
        /// </summary>
        /// <returns>Link or specified text.</returns>
        public static MvcHtmlString AuthorizedActionLinkOrText(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, object routeValues, object htmlAttributes)
        {
            return AuthorizedActionLinkOrText(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: controllerName,
                protocol: protocol,
                hostName: hostName,
                fragment: fragment,
                routeValues: new RouteValueDictionary(routeValues),
                htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes)
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays specified text.
        /// </summary>
        /// <returns>Link or specified text.</returns>
        public static MvcHtmlString AuthorizedActionLinkOrText(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
        {
            // See if user has access to the action.
            if (ActionIsAccessibleToUser(htmlHelper: htmlHelper, actionName: actionName, controllerName: controllerName, routeValues: routeValues))
            {
                // User has access. Generate ActionLink.
                return LinkExtensions.ActionLink(htmlHelper, linkText, actionName, controllerName, protocol, hostName, fragment, routeValues, htmlAttributes);
            }
            else
            {
                // User does not have access. Return link text.
                return MvcHtmlString.Create(linkText);
            }
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays nothing.
        /// </summary>
        /// <returns>Link or empty string.</returns>
        public static MvcHtmlString AuthorizedActionLink(this HtmlHelper htmlHelper, string linkText, string actionName)
        {
            return AuthorizedActionLink(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: null,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: null,
                htmlAttributes: null
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays nothing.
        /// </summary>
        /// <returns>Link or empty string.</returns>
        public static MvcHtmlString AuthorizedActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, object routeValues)
        {
            return AuthorizedActionLink(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: null,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: new RouteValueDictionary(routeValues),
                htmlAttributes: null
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays nothing.
        /// </summary>
        /// <returns>Link or empty string.</returns>
        public static MvcHtmlString AuthorizedActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName)
        {
            return AuthorizedActionLink(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: controllerName,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: null,
                htmlAttributes: null
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays nothing.
        /// </summary>
        /// <returns>Link or empty string.</returns>
        public static MvcHtmlString AuthorizedActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, RouteValueDictionary routeValues)
        {
            return AuthorizedActionLink(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: null,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: routeValues,
                htmlAttributes: null
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays nothing.
        /// </summary>
        /// <returns>Link or empty string.</returns>
        public static MvcHtmlString AuthorizedActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, object routeValues, object htmlAttributes)
        {
            return AuthorizedActionLink(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: null,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: new RouteValueDictionary(routeValues),
                htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes)
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays nothing.
        /// </summary>
        /// <returns>Link or empty string.</returns>
        public static MvcHtmlString AuthorizedActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
        {
            return AuthorizedActionLink(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: null,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: routeValues,
                htmlAttributes: htmlAttributes
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays nothing.
        /// </summary>
        /// <returns>Link or empty string.</returns>
        public static MvcHtmlString AuthorizedActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, object routeValues, object htmlAttributes)
        {
            return AuthorizedActionLink(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: controllerName,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: new RouteValueDictionary(routeValues),
                htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes)
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays nothing.
        /// </summary>
        /// <returns>Link or empty string.</returns>
        public static MvcHtmlString AuthorizedActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
        {
            return AuthorizedActionLink(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: controllerName,
                protocol: null,
                hostName: null,
                fragment: null,
                routeValues: routeValues,
                htmlAttributes: htmlAttributes
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays nothing.
        /// </summary>
        /// <returns>Link or empty string.</returns>
        public static MvcHtmlString AuthorizedActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, object routeValues, object htmlAttributes)
        {
            return AuthorizedActionLink(
                htmlHelper: htmlHelper,
                linkText: linkText,
                actionName: actionName,
                controllerName: controllerName,
                protocol: protocol,
                hostName: hostName,
                fragment: fragment,
                routeValues: new RouteValueDictionary(routeValues),
                htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes)
                );
        }

        /// <summary>
        /// Checks user security permissions.  If allowed, displays link. Otherwise, displays nothing.
        /// </summary>
        /// <returns>Link or empty string.</returns>
        public static MvcHtmlString AuthorizedActionLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, RouteValueDictionary routeValues, IDictionary<string, object> htmlAttributes)
        {
            // See if user has access to the action.
            if (ActionIsAccessibleToUser(htmlHelper: htmlHelper, actionName: actionName, controllerName: controllerName, routeValues: routeValues))
            {
                // User has access. Generate ActionLink.
                return LinkExtensions.ActionLink(htmlHelper, linkText, actionName, controllerName, protocol, hostName, fragment, routeValues, htmlAttributes);
            }
            else
            {
                // User does not have access. Return empty string.
                return MvcHtmlString.Empty;
            }
        }


        /// <summary>
        /// Determines if specified action is accessible to current user.
        /// </summary>
        /// <param name="htmlHelper">HtmlHelper object.</param>
        /// <param name="actionName">Action name to test.</param>
        /// <returns>True/false if action is accessible to current user.</returns>
        public static bool ActionIsAccessibleToUser(this HtmlHelper htmlHelper, string actionName)
        {
            return ActionIsAccessibleToUser(
                htmlHelper: htmlHelper,
                actionName: actionName,
                controllerName: null,
                routeValues: null
                );
        }

        /// <summary>
        /// Determines if specified action is accessible to current user.
        /// </summary>
        /// <param name="htmlHelper">HtmlHelper object.</param>
        /// <param name="actionName">Action name to test.</param>
        /// <param name="controllerName">Controller name to test.</param>
        /// <param name="routeValues">Route values to test.</param>
        /// <returns>True/false if action is accessible to current user.</returns>
        public static bool ActionIsAccessibleToUser(this HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues)
        {
            return ActionIsAccessibleToUser(
                htmlHelper: htmlHelper,
                actionName: actionName,
                controllerName: controllerName,
                routeValues: new RouteValueDictionary(routeValues)
                );
        }

        /// <summary>
        /// Determines if specified action is accessible to current user.
        /// </summary>
        /// <param name="htmlHelper">HtmlHelper object.</param>
        /// <param name="actionName">Action name to test.</param>
        /// <param name="controllerName">Controller name to test.</param>
        /// <param name="routeValues">Route values to test.</param>
        /// <returns>True/false if action is accessible to current user.</returns>
        public static bool ActionIsAccessibleToUser(this HtmlHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            // Define variables.
            ControllerBase controllerBase;
            string areaName = String.Empty;
            string[] namespaceNames = new string[] { };
            bool hasArea = false, hasNamespaces = false;

            // Throw error if both actionName is empty.
            if (String.IsNullOrWhiteSpace(actionName))
            {
                throw new ArgumentException("actionName must be specified.", "actionName");
            }

            // Pull out area and namespace names if they exist.
            if (routeValues != null)
            {
                // See if an area is specified.
                if (routeValues.ContainsKey("Area"))
                {
                    areaName = (string)routeValues["Area"];
                    hasArea = true;
                }

                // See if a namespace has been specified.
                if (routeValues.ContainsKey("Namespaces"))
                {
                    namespaceNames = (string[])routeValues["Namespaces"];
                    hasNamespaces = true;
                }
            }

            // Fetch controller. See if one was specified.            
            if (string.IsNullOrWhiteSpace(controllerName))
            {
                // No controller was specified. Assume current controller.
                controllerBase = htmlHelper.ViewContext.Controller;
            }
            else
            {
                // Search for specified controller.

                // See if area and/or namespaces were specified. If so, create a new context for searching. Otherwise, use existing.
                RequestContext requestContext;
                if (hasArea || hasNamespaces)
                {
                    // Construct new context.
                    // Get request context to use in searching for controller.
                    requestContext = new RequestContext(htmlHelper.ViewContext.RequestContext.HttpContext, new RouteData());
                    requestContext.RouteData.DataTokens["Controller"] = controllerName;

                    // Set area name if it has been specified.
                    if (hasArea)
                    {
                        requestContext.RouteData.DataTokens["Area"] = areaName;
                    }

                    // Set namespaces if they have been specified.
                    if (hasNamespaces)
                    {
                        requestContext.RouteData.DataTokens["Namespaces"] = namespaceNames;
                    }
                }
                else
                {
                    // No area or namespaces specified. Use existing context.
                    requestContext = htmlHelper.ViewContext.RequestContext;
                }

                // Get controller factory.
                var controllerFactory = ControllerBuilder.Current.GetControllerFactory();

                // Attempt to get controller.
                IController controller = null;
                try
                {
                    // Get controller.
                    controller = controllerFactory.CreateController(requestContext, controllerName);
                }
                catch (HttpException)
                {
                    // Could not create controller. Rethrow as ArgumentException.
                    throw new ArgumentException("Specified controller " + controllerName + " does not exist.");
                }

                // Ensure controller exists.
                if (controller == null)
                {
                    // Controller doesn't exist.
                    throw new ArgumentException("Specified controller " + controllerName + " does not exist.");
                }

                // Use controller.
                controllerBase = (ControllerBase)controller;
            }

            return ActionIsAccessibleToUser(htmlHelper, actionName, controllerBase);
        }

        /// <summary>
        /// Determines if specified action is accessible to current user.
        /// </summary>
        /// <param name="htmlHelper">HtmlHelper object.</param>
        /// <param name="actionName">Action name to test.</param>
        /// <param name="controllerName">Controller name to test.</param>
        /// <param name="areaName">Area name to test.</param>
        /// <returns>True/false if action is accessible to current user.</returns>
        public static bool ActionIsAccessibleToUser(this HtmlHelper htmlHelper, string actionName, string controllerName, string areaName)
        {
            return ActionIsAccessibleToUser(
                htmlHelper: htmlHelper,
                actionName: actionName,
                controllerName: controllerName,
                routeValues: new { Area = areaName }
                );
        }

        /// <summary>
        /// Determines if specified action is accessible to current user.
        /// </summary>
        /// <param name="htmlHelper">HtmlHelper object.</param>
        /// <param name="actionName">Action name to test.</param>
        /// <param name="controllerName">Controller name to test.</param>
        /// <returns>True/false if action is accessible to current user.</returns>
        public static bool ActionIsAccessibleToUser(this HtmlHelper htmlHelper, string actionName, string controllerName)
        {
            return ActionIsAccessibleToUser(
                htmlHelper: htmlHelper,
                actionName: actionName,
                controllerName: controllerName,
                routeValues: null
                );
        }

        /// <summary>
        /// Determines if specified action is accessible to current user.
        /// </summary>
        /// <param name="htmlHelper">HtmlHelper object.</param>
        /// <param name="actionName">Action name to test.</param>
        /// <param name="controllerBase">Controller to test.</param>
        /// <returns>True/false if action is accessible to current user.</returns>
        private static bool ActionIsAccessibleToUser(this HtmlHelper htmlHelper, string actionName, ControllerBase controllerBase)
        {
            // Get controller context.
            var controllerContext = new ControllerContext(htmlHelper.ViewContext.RequestContext, controllerBase);

            // Get controller descriptor.
            var controllerDescriptor = new ReflectedControllerDescriptor(controllerBase.GetType());

            // Get action descriptor.
            var actionDescriptor = controllerDescriptor.FindAction(controllerContext, actionName);

            // Check on authorization.
            return ActionIsAuthorized(actionDescriptor, controllerContext);
        }

        /// <summary>
        /// Tests if authorization works for action.
        /// </summary>
        /// <param name="actionDescriptor">Action to test.</param>
        /// <param name="controllerContext">Controller context (including user) to test.</param>
        /// <returns>True/false if action is authorized.</returns>
        private static bool ActionIsAuthorized(ActionDescriptor actionDescriptor, ControllerContext controllerContext)
        {
            if (actionDescriptor == null)
            {
                // Action does not exist.
                return false;
            }

            // Get authorization context fo controller.
            AuthorizationContext authContext = new AuthorizationContext(controllerContext, actionDescriptor);

            // run each auth filter until on fails
            // performance could be improved by some caching
            var filters = FilterProviders.Providers.GetFilters(controllerContext, actionDescriptor);
            FilterInfo filterInfo = new FilterInfo(filters);

            foreach (IAuthorizationFilter authFilter in filterInfo.AuthorizationFilters)
            {
                // Attempt authorization.
                authFilter.OnAuthorization(authContext);

                // If result is non-null, user is not authorized.
                if (authContext.Result != null)
                {
                    return false;
                }
            }

            // Assume user is authorized.
            return true;
        }
    }
}
