using System.Collections.Generic;

public class ShoelaceMetadata
{
    public string schemaVersion { get; set; }
    public string readme { get; set; }
    public List<ShoelaceModule> modules { get; set; } = new();
}

public class ShoelaceModule
{
    public string kind { get; set; }
    public string path { get; set; }
    public List<ShoelaceDeclaration> declarations { get; set; } = new();
}

public class ShoelaceDeclaration
{
    public string kind { get; set; }
    public string description { get; set; }
    public string name { get; set; }
    public List<ShoelaceCssPart> cssParts { get; set; } = new();
    public List<ShoelaceSlot> slots { get; set; } = new();
    public List<ShoelaceMember> members { get; set; } = new();
    public List<ShoelaceEvent> events { get; set; } = new();
    public List<ShoelaceProperty> attributes { get; set; } = new();
    public string summary { get; set; }
    public List<ShoelaceAnimation> animations { get; set; } = new();
    public string tagName { get; set; }
}

public class ShoelaceCssPart
{
    public string description { get; set; }
    public string name { get; set; }
}

public class ShoelaceSlot
{
    public string description { get; set; }
    public string name { get; set; }
}

public class ShoelaceMember
{
    public string kind { get; set; }
    public string name { get; set; }
    public ShoelaceType type { get; set; } = new();
    public string description { get; set; } = string.Empty;
    public string attribute { get; set; }
    public string @default { get; set; }
    public bool @static { get; set; }
    public string privacy { get; set; }
    public bool reflects { get; set; }
    public bool @readonly { get; set; }
}

public class ShoelaceType
{
    public string text { get; set; } = string.Empty;
}

public class ShoelaceEvent
{
    public string description { get; set; }
    public string name { get; set; } // js event-name
    public string eventName { get; set; } // class name
    public ShoelaceType type { get; set; } = new();
}

public class ShoelaceProperty
{
    public string name { get; set; }
    public ShoelaceType type { get; set; }
    public string @default { get; set; }
    public string description { get; set; }
    public string attribute { get; set; }
}

public class ShoelaceAnimation
{
    public string name { get; set; }
    public string description { get; set; }
}