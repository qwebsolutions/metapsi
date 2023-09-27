using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Tutorial.Samples;

/// <summary>
/// Linq expression
/// </summary>
public class DataModelLinq : TutorialSample<DataModelLinq.Model>
{
    public class Model
    {
        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public List<User> LoggedUsers { get; set; }
    }

    public static Var<HyperNode> Render(BlockBuilder b, Var<Model> model)
    {
        var over21 = b.Get(model, x => x.LoggedUsers.Where(x => x.Age >= 21).Count());
        return b.Text(b.AsString(over21));
    }

    public override Model GetSampleData()
    {
        return new Model()
        {
            LoggedUsers = new List<Model.User>()
            {
                new Model.User()
                {
                    Name = "Susan",
                    Age = 32
                },
                new Model.User()
                {
                   Name = "John",
                   Age = 21
                },
                new Model.User()
                {
                    Name = "James",
                    Age = 20
                },
                new Model.User()
                {
                    Name = "Jennifer",
                    Age = 18
                },
                new Model.User()
                {
                    Name = "Robert",
                    Age = 18
                },
                new Model.User()
                {
                    Name = "Michael",
                    Age = 24
                }
            }
        };
    }
}