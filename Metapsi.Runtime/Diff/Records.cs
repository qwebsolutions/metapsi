using System.Linq;

namespace Metapsi
{
    /// <summary>
    /// 
    /// </summary>
    [DataItem("0c82c279-940d-4f25-b53e-04c2dfbd3c58")]
    public partial class AddedDataItem : IRecord
    {
        [DataItemField("6c6c631c-9ca9-47e8-958e-1744ca799083")]
        [ScalarTypeName("Id")]
        public System.Guid Id { get; set; } = System.Guid.NewGuid();
        [DataItemField("e3017e1e-75f7-4420-bf1d-ffdba10ff2c5")]
        [ScalarTypeName("Id")]
        public System.Guid DataItemId { get; set; }

        [DataItemField("b3e06d26-e359-49b0-9f5a-009622f211ff")]
        [ScalarTypeName("String")]
        public System.String DataItemType { get; set; } = System.String.Empty;
        [DataItemField("1f9dcd2b-8206-4eee-bfad-8d628b8b29ca")]
        [ScalarTypeName("String")]
        public System.String InDataStructureCollection { get; set; } = System.String.Empty;
    }

    /// <summary>
    /// 
    /// </summary>
    [DataItem("35065bb0-e927-4591-b452-286f79393177")]
    public partial class ChangedDataItem : IRecord
    {
        [DataItemField("957c58ea-8adb-4613-b5cc-90160d652f9f")]
        [ScalarTypeName("Id")]
        public System.Guid Id { get; set; } = System.Guid.NewGuid();
        [DataItemField("7da9163d-0e0d-4e1f-840c-6611e02e7583")]
        [ScalarTypeName("Id")]
        public System.Guid DataItemId { get; set; }

        [DataItemField("0e71b5e8-c291-4a3c-af81-d8ce99d6b1ca")]
        [ScalarTypeName("String")]
        public System.String DataItemType { get; set; } = System.String.Empty;
        [DataItemField("ad53b7b6-7bb4-44d2-bd7b-61d5118659d9")]
        [ScalarTypeName("String")]
        public System.String InDataStructureCollection { get; set; } = System.String.Empty;
    }

    /// <summary>
    /// 
    /// </summary>
    [DataItem("7f2347e4-81e1-40d8-9141-408b755ef4dc")]
    public partial class ChangedItemProperty : IRecord
    {
        [DataItemField("0d4d064e-e13e-4222-ac1f-d91a03f480f6")]
        [ScalarTypeName("Id")]
        public System.Guid Id { get; set; } = System.Guid.NewGuid();
        [DataItemField("09b40285-6d71-4daa-9892-33f8b28442c4")]
        [ScalarTypeName("Id")]
        public System.Guid ChangeId { get; set; }

        [DataItemField("1095f461-34ee-4c68-a331-a6546a409086")]
        [ScalarTypeName("String")]
        public System.String PropertyName { get; set; } = System.String.Empty;
        [DataItemField("a85dd34c-5736-4c02-8c1d-ab66f3f28094")]
        [ScalarTypeName("String")]
        public System.String PropertyValue { get; set; } = System.String.Empty;
        [DataItemField("0e2cdf85-bd17-4a83-928e-d2c539a1a8b3")]
        [ScalarTypeName("String")]
        public System.String ScalarTypeName { get; set; } = System.String.Empty;
    }

    /// <summary>
    /// 
    /// </summary>
    [DataItem("92863511-b7d6-41f1-ab17-4693ae85766e")]
    public partial class DiffHeader : IRecord
    {
        [DataItemField("931a2190-70fa-4326-8734-67098fd7de4a")]
        [ScalarTypeName("Id")]
        public System.Guid Id { get; set; } = System.Guid.NewGuid();
        [DataItemField("29879f3b-0581-4cf9-89f3-1dd25f964939")]
        [ScalarTypeName("String")]
        public System.String StructureTypeName { get; set; } = System.String.Empty;
    }

    /// <summary>
    /// 
    /// </summary>
    [DataItem("99f063f4-e847-459d-9d1f-ff7f457103a3")]
    public partial class RemovedDataItem : IRecord
    {
        [DataItemField("ed391272-3f00-4f8e-afd0-e3acfc7a896c")]
        [ScalarTypeName("Id")]
        public System.Guid Id { get; set; } = System.Guid.NewGuid();
        [DataItemField("ce709623-1b16-4bef-8cec-22acfbd121de")]
        [ScalarTypeName("Id")]
        public System.Guid DataItemId { get; set; }

        [DataItemField("dba9f91c-6a96-4b9b-84a5-92bb8c2914e2")]
        [ScalarTypeName("String")]
        public System.String DataItemType { get; set; } = System.String.Empty;
        [DataItemField("eda04a11-1f9e-403e-b0fb-af6c89f7d0c4")]
        [ScalarTypeName("String")]
        public System.String FromDataStructureCollection { get; set; } = System.String.Empty;
    }

    /// <summary>
    /// 
    /// </summary>
    [DataItem("773502fe-7a53-4692-944e-773d8b590459")]
    public partial class ResultMapping : IRecord
    {
        [DataItemField("2cc65fe8-e4b3-4925-8836-af583ec7d886")]
        [ScalarTypeName("Id")]
        public System.Guid Id { get; set; } = System.Guid.NewGuid();
        [DataItemField("5c992d71-293b-415a-b5f6-e3106b1a6a44")]
        [ScalarTypeName("Id")]
        public System.Guid DefinitionId { get; set; }

        [DataItemField("c43c7553-63bb-4cbf-9266-2400b2271ed7")]
        [ScalarTypeName("Id")]
        public System.Guid OnDataItemId { get; set; }

        [DataItemField("a87e6d06-5353-4bf3-bbc5-d0e73ec32a70")]
        [ScalarTypeName("Id")]
        public System.Guid ResultId { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [DataStructure("e30e19ac-9bdf-4d2e-b520-fe70495deaa4")]
    public partial class DataStructureDiff 
    {
        public RecordCollection<DiffHeader> DiffHeader { get; set; } = new RecordCollection<DiffHeader>();
        public RecordCollection<AddedDataItem> AddedItems { get; set; } = new RecordCollection<AddedDataItem>();
        public RecordCollection<ChangedDataItem> ChangedItems { get; set; } = new RecordCollection<ChangedDataItem>();
        public RecordCollection<RemovedDataItem> RemovedItems { get; set; } = new RecordCollection<RemovedDataItem>();
        public RecordCollection<ChangedItemProperty> ItemProperties { get; set; } = new RecordCollection<ChangedItemProperty>();

        public bool HasChanges => RemovedItems.Any() || ItemProperties.Any();
    }
}