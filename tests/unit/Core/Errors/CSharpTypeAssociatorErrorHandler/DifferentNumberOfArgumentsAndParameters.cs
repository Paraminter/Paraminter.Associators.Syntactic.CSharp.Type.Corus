﻿namespace Paraminter.Associating.CSharp.Type.Corus.Errors;

using Paraminter.Associating.CSharp.Type.Corus.Errors.Commands;
using Paraminter.Cqs.Handlers;

using Xunit;

public sealed class DifferentNumberOfArgumentsAndParameters
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void ReturnsHandler()
    {
        var result = Target();

        Assert.Same(Fixture.DifferentNumberOfArgumentsAndParametersMock.Object, result);
    }

    private ICommandHandler<IHandleDifferentNumberOfArgumentsAndParametersCommand> Target() => Fixture.Sut.DifferentNumberOfArgumentsAndParameters;
}
