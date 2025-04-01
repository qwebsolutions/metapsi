namespace Metapsi.Ionic;

public interface Animation { }
public interface AnimationBuilder { }
public interface DatetimeHighlightStyle { }
public interface DatetimeHighlight { }
public interface FocusEvent { }
public interface Function { }
public interface GestureDetail { }
public interface HTMLFormElement { }
public interface HTMLIonPickerColumnInternalElement { }
public interface HTMLIonBreadcrumbElement { }
public interface Mode { }
public interface NavDirection { }
public interface NavComponent { }
public interface RangeValue { }
public interface SegmentValue { }
public interface TransitionDoneFn { }
public interface ViewController { }

public class PickerColumnOption
{
    public string text { get; set; }
    public object value { get; set; }
    public bool disabled { get; set; }
    public int duration { get; set; }
    public string transform { get; set; }
    public bool selected { get; set; }
    /// <summary>
    ///The optional text to assign as the aria-label on the picker column option.
    /// </summary>
    public string ariaLabel { get; set; }
}

public class DateTimeFormatOptions
{

}

public class PickerColumnValue
{

}

public class HTMLIonPickerColumnElement
{

}

public interface IonicSafeString
{

}