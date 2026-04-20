using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// A web application manifest, defined in the Web Application Manifest specification, is a JSON text file that provides information about a web application.
/// <para>The most common use for a web application manifest is to provide information that the browser needs to install a progressive web app(PWA) on a device, such as the app's name and icon.</para>
/// </summary>
public class WebAppManifest
{
    /// <summary>
    /// The background_color manifest member is used to specify an initial background color for your web application. This color appears in the application window before your application's stylesheets have loaded.
    /// </summary>
    public string background_color { get; set; }

    /// <summary>
    /// The categories manifest member lets you specify one or more classifications for your web application. These categories help users discover your app in app stores.
    /// </summary>
    public List<string> categories { get; set; }

    /// <summary>
    /// The description manifest member is used to explain the core features or functionality of your web application. This text helps users understand your app's purpose when viewing it in an app store.
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// The display manifest member is used to specify your preferred display mode for the web application. The display mode determines how much of the browser UI is shown to the user when the app is launched within the context of an operating system. You can choose to show the full browser interface or hide it to provide a more app-like experience.
    /// </summary>
    public string display { get; set; } = "standalone";

    /// <summary>
    /// The icons manifest member is used to specify one or more image files that define the icons to represent your web application.
    /// </summary>
    public List<WebAppManifestIcon> icons { get; set; }

    /// <summary>
    /// The id manifest member is used to specify a unique identifier for your web application. It is a string that takes the form of a URL. The URL must be same-origin with the start_url of your web app. If id is a relative URL, it is resolved using the origin of start_url. Any fragment in the id is always ignored. If id is not specified or the value is invalid in any way (such as not a string, not a valid URL, not same-origin with start_url), the start_url value is used.
    /// </summary>
    public string id { get; set; }

    /// <summary>
    /// The name manifest member is used to specify the full name of your web application as it's usually displayed to users, such as in application lists or as a label for your application's icon.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// The orientation manifest member is used to specify the default orientation for your web application. It defines how the app should be displayed when launched and during use, in relation to the device's screen orientation, particularly on devices that support multiple orientations.
    /// </summary>
    public string orientation { get; set; }

    /// <summary>
    /// The scope manifest member is used to specify the top-level URL path that contains your web application's pages and subdirectories. When users install and use your web app, pages within scope provide an app-like interface. When users navigate to pages outside the app's scope, they still experience the app-like interface, but browsers display UI elements like the URL bar to indicate the change in context.
    /// </summary>
    public string scope { get; set; }

    /// <summary>
    /// The screenshots manifest member lets you specify one or more images that showcase your web application. These images help users preview your web app's interface and features in app stores.
    /// </summary>
    public List<WebAppManifestScreenshot> screenshots { get; set; }

    /// <summary>
    /// The short_name manifest member is used to specify a short name for your web application, which may be used when the full name is too long for the available space.
    /// </summary>
    public string short_name { get; set; }

    /// <summary>
    /// The shortcuts manifest member is used to specify links to key tasks or pages within your web application. Browsers can use this information to create a context menu, which is typically displayed when a user interacts with the web app's icon.
    /// </summary>
    public List<WebAppManifestShortcut> shortcuts { get; set; }

    /// <summary>
    /// The start_url manifest member is used to specify the URL that should be opened when a user launches your web application, such as when tapping the application's icon on their device's home screen or in an application list.
    /// </summary>
    public string start_url { get; set; } = ".";

    /// <summary>
    /// The theme_color member is used to specify the default color for your web application's user interface. This color may be applied to various browser UI elements, such as the toolbar, address bar, and status bar. It can be particularly noticeable in contexts like the task switcher or when the app is added to the home screen.
    /// </summary>
    public string theme_color { get; set; }
}

/// <summary>
/// 
/// </summary>
public class WebAppManifestIcon
{
    /// <summary>
    /// A string that specifies the path to the icon image file. If src is relative, the path is resolved relative to the manifest file's URL.
    /// </summary>
    public string src { get; set; }

    /// <summary>
    /// A string that specifies one or more sizes at which the icon file can be used. Each size is specified as &lt;width in pixels&gt;x&lt;height in pixels&gt;. If multiple sizes are specified, they are separated by spaces; for example, 48x48 96x96. When multiple icons are available, browsers may select the most suitable icon for a particular display context. For raster formats like PNG, specifying the exact available sizes is recommended. For vector formats like SVG, you can use any to indicate scalability. If sizes is not specified, the selection and display of the icon may vary depending on the browser's implementation.
    /// </summary>
    public string sizes { get; set; }

    /// <summary>
    /// A string that specifies the MIME type of the icon. The value should be in the format image/&lt;subtype&gt;, where &lt;subtype&gt; is a specific image format; for example, image/png indicates a PNG image. If omitted, browsers typically infer the image type from the file extension.
    /// </summary>
    public string type { get; set; }

    /// <summary>
    /// A case-sensitive keyword string that specifies one or more contexts in which the icon can be used by the browser or operating system. The value can be a single keyword or multiple space-separated keywords. If omitted, the browser can use the icon for any purpose.
    /// <para>Valid values include:</para>
    ///<para>monochrome - Indicates that the icon is intended to be used as a monochrome icon with a solid fill.With this value, a browser discards the color information in the icon and uses only the alpha channel as a mask over any solid fill.</para>
    ///<para>maskable - Indicates that the icon is designed with icon masks and safe zone in mind, such that any part of the image outside the safe zone can be ignored and masked away.</para>
    ///<para>any - Indicates that the icon can be used in any context. This is the default value.</para>
    /// </summary>
    public string purpose { get; set; }
}

/// <summary>
/// 
/// </summary>
public class WebAppManifestScreenshot
{
    /// <summary>
    /// A string that specifies the path to the image file. It has the same format as the icons member's src property.
    /// </summary>
    public string src { get; set; }

    /// <summary>
    /// A string that specifies one or more sizes of the image. It has the same format as the icons member's sizes property.
    /// </summary>
    public string sizes { get; set; }

    /// <summary>
    /// A string that specifies the MIME type of the image. It has the same format as the icons member's type property.
    /// </summary>
    public string type { get; set; }

    /// <summary>
    /// A string that represents the accessible name of the screenshot object. Keep it descriptive because it can serve as alternative text for the rendered screenshot. For accessibility, it is recommended to specify this property for every screenshot.
    /// </summary>
    public string label { get; set; }

    /// <summary>
    /// A string that represents the screen shape of a broad class of devices to which the screenshot applies.Specify this property only when the screenshot applies to a specific screen layout.If form_factor is not specified, the screenshot is considered suitable for all screen types.
    /// <para>Valid values include:</para>
    /// <para>narrow - Indicates that the screenshot is applicable only to narrow screens, such as mobile devices.</para>
    /// <para>wide - Indicates that the screenshot is applicable only to wide screens, such as desktop computers.</para>
    /// </summary>
    public string form_factor { get; set; }

    /// <summary>
    /// A string that represents the platform to which the screenshot applies. Specify this property only when the screenshot applies to a specific device or distribution platform. If platform is not specified, the screenshot is considered suitable for all platforms.
    /// </summary>
    public string platform { get; set; }
}

/// <summary>
/// 
/// </summary>
public class WebAppManifestShortcut
{
    /// <summary>
    /// A string that represents the name of the shortcut, which is displayed to users in a context menu.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// A string that represents a short version of the shortcut's name. Browsers may use this in contexts where there isn't enough space to display the full name.
    /// </summary>
    public string short_name { get; set; }

    /// <summary>
    /// A string that describes the purpose of the shortcut. Browsers may expose this information to assistive technology, such as screen readers, which can help users understand the purpose of the shortcut.
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// An app URL that opens when the associated shortcut is activated. The URL must be within the scope of the web app manifest. If the value is absolute, it should be same-origin with the page that links to the manifest file. If the value is relative, it is resolved against the manifest file's URL.
    /// </summary>
    public string url { get; set; }

    /// <summary>
    /// An array of icon objects representing the shortcut in various contexts. This has the same format as the icons manifest member.
    /// </summary>
    public List<WebAppManifestIcon> icons { get; set; } = new();
}

//public class WebAppManifestConfiguration
//{
//    public string Path { get; set; } = "manifest.json";
//    public WebAppManifest Manifest { get; set; } = new();
//}

public static partial class FiExtensions
{
    /// <summary>
    /// Creates &lt;link rel="manifest" href="<paramref name="manifestPath"/>"&gt;
    /// </summary>
    /// <param name="b"></param>
    /// <param name="manifestPath"></param>
    public static IHtmlNode PwaManifest(this HtmlBuilder b, string manifestPath)
    {
        return b.HtmlLink(
            b =>
            {
                b.SetRel("manifest");
                b.SetHref(manifestPath);
            });
    }

    /// <summary>
    /// Appends the <see cref="PwaManifest(HtmlBuilder, string)"/> link to the web app manifest to the html document header
    /// </summary>
    /// <param name="b"></param>
    /// <param name="manifestPath"></param>
    public static void AddPwaManifest(this HtmlBuilder b, string manifestPath)
    {
        b.HeadAppend(b.PwaManifest(manifestPath));
    }
}
