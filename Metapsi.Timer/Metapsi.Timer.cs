//using System.Linq;
//using Metapsi.Reflection;

//namespace Metapsi
//{
//    /// <summary>
//        /// Single component that handles all the timers
//        /// </summary>
//    public static partial class Timer
//    {
//        /// <summary>
//                /// 
//                /// </summary>
//        public static partial class Command
//        {
//            /// <summary>
//                        /// 
//                        /// </summary>
//            [Metapsi.Reflection.DataItem("93a9e471-009b-432f-b749-536457909635")]
//            public partial class Remove : Metapsi.Reflection.IRecord, Metapsi.Reflection.IClonable<Metapsi.Timer.Command.Remove>
//            {
//                [Metapsi.Reflection.DataItemField("2ad3214d-26e8-455b-9dcc-b26ca6b3e840")]
//                [Metapsi.Reflection.ScalarTypeName("Id")]
//                public System.Guid Id { get; set; } = System.Guid.NewGuid();
//                [Metapsi.Reflection.DataItemField("70ad90b3-1ef1-4ac6-8efc-4cba43c1ffba")]
//                [Metapsi.Reflection.ScalarTypeName("String")]
//                public System.String Name { get; set; } = System.String.Empty;
//                public Metapsi.Timer.Command.Remove Clone()
//                {
//                    var clone = new Metapsi.Timer.Command.Remove();
//                    clone.Id = this.Id;
//                    clone.Name = this.Name;
//                    return clone;
//                }

//                public static System.Guid GetId(Metapsi.Timer.Command.Remove dataRecord)
//                {
//                    return dataRecord.Id;
//                }

//                public static System.String GetName(Metapsi.Timer.Command.Remove dataRecord)
//                {
//                    return dataRecord.Name;
//                }
//            }

//            /// <summary>
//                        /// 
//                        /// </summary>
//            [Metapsi.Reflection.DataItem("2f69cf1d-9627-4d64-86e4-7722f73520a0")]
//            public partial class Set : Metapsi.Reflection.IRecord, Metapsi.Reflection.IClonable<Metapsi.Timer.Command.Set>
//            {
//                [Metapsi.Reflection.DataItemField("227ff905-bbb8-4607-a314-0049de927ad4")]
//                [Metapsi.Reflection.ScalarTypeName("Id")]
//                public System.Guid Id { get; set; } = System.Guid.NewGuid();
//                [Metapsi.Reflection.DataItemField("4f243bde-db9a-46ed-b684-d40ed4194357")]
//                [Metapsi.Reflection.ScalarTypeName("String")]
//                public System.String Name { get; set; } = System.String.Empty;
//                [Metapsi.Reflection.DataItemField("2116d0b1-9c9d-4cdc-a015-3860ecbb2a03")]
//                [Metapsi.Reflection.ScalarTypeName("Int")]
//                public System.Int32 IntervalMilliseconds { get; set; }

//                [Metapsi.Reflection.DataItemField("c05e9d8f-e487-422d-aa24-53372111e710")]
//                [Metapsi.Reflection.ScalarTypeName("String")]
//                public System.String Data { get; set; } = System.String.Empty;
//                public Metapsi.Timer.Command.Set Clone()
//                {
//                    var clone = new Metapsi.Timer.Command.Set();
//                    clone.Id = this.Id;
//                    clone.Name = this.Name;
//                    clone.IntervalMilliseconds = this.IntervalMilliseconds;
//                    clone.Data = this.Data;
//                    return clone;
//                }

//                public static System.Guid GetId(Metapsi.Timer.Command.Set dataRecord)
//                {
//                    return dataRecord.Id;
//                }

//                public static System.String GetName(Metapsi.Timer.Command.Set dataRecord)
//                {
//                    return dataRecord.Name;
//                }

//                public static System.Int32 GetIntervalMilliseconds(Metapsi.Timer.Command.Set dataRecord)
//                {
//                    return dataRecord.IntervalMilliseconds;
//                }

//                public static System.String GetData(Metapsi.Timer.Command.Set dataRecord)
//                {
//                    return dataRecord.Data;
//                }
//            }
//        }

//        /// <summary>
//                /// 
//                /// </summary>
//        public static partial class Event
//        {
//            /// <summary>
//                        /// 
//                        /// </summary>
//            [Metapsi.Reflection.DataItem("3a8787c3-f6d5-4e1f-854d-94d1018c936c")]
//            public partial class Tick : Metapsi.Reflection.IRecord, Metapsi.Reflection.IClonable<Metapsi.Timer.Event.Tick>
//            {
//                [Metapsi.Reflection.DataItemField("a0711c52-d914-4d71-a212-5fbb634706ed")]
//                [Metapsi.Reflection.ScalarTypeName("Id")]
//                public System.Guid Id { get; set; } = System.Guid.NewGuid();
//                [Metapsi.Reflection.DataItemField("5dfd049b-7a34-48be-be55-9285e49cb13f")]
//                [Metapsi.Reflection.ScalarTypeName("String")]
//                public System.String Name { get; set; } = System.String.Empty;
//                [Metapsi.Reflection.DataItemField("bd9fdf78-24b5-43a6-b6ff-3167271ec1da")]
//                [Metapsi.Reflection.ScalarTypeName("String")]
//                public System.String Data { get; set; } = System.String.Empty;
//                public Metapsi.Timer.Event.Tick Clone()
//                {
//                    var clone = new Metapsi.Timer.Event.Tick();
//                    clone.Id = this.Id;
//                    clone.Name = this.Name;
//                    clone.Data = this.Data;
//                    return clone;
//                }

//                public static System.Guid GetId(Metapsi.Timer.Event.Tick dataRecord)
//                {
//                    return dataRecord.Id;
//                }

//                public static System.String GetName(Metapsi.Timer.Event.Tick dataRecord)
//                {
//                    return dataRecord.Name;
//                }

//                public static System.String GetData(Metapsi.Timer.Event.Tick dataRecord)
//                {
//                    return dataRecord.Data;
//                }
//            }
//        }
//    }
//}