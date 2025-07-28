using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi.Html;

/// <summary>
/// The FontFaceSet interface of the CSS Font Loading API manages the loading of font-faces and querying of their download status.
/// A FontFaceSet instance is a Set-like object that can hold an ordered set of FontFace objects.
/// This property is available as Document.fonts, or self.fonts in web workers.
/// </summary>
public interface FontFaceSet: EventTarget
{

}