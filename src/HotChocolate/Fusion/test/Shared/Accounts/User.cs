using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace HotChocolate.Fusion.Shared.Accounts;

[Node]
public record User(
    int Id,
    string Name,
    [property: GraphQLType<NonNullType<DateType>>] DateTime Birthdate,
    string Username);
