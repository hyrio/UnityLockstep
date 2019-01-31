//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Lockstep.Core.Components.Game.DestinationComponent destination { get { return (Lockstep.Core.Components.Game.DestinationComponent)GetComponent(GameComponentsLookup.Destination); } }
    public bool hasDestination { get { return HasComponent(GameComponentsLookup.Destination); } }

    public void AddDestination(BEPUutilities.Vector2 newValue) {
        var index = GameComponentsLookup.Destination;
        var component = (Lockstep.Core.Components.Game.DestinationComponent)CreateComponent(index, typeof(Lockstep.Core.Components.Game.DestinationComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDestination(BEPUutilities.Vector2 newValue) {
        var index = GameComponentsLookup.Destination;
        var component = (Lockstep.Core.Components.Game.DestinationComponent)CreateComponent(index, typeof(Lockstep.Core.Components.Game.DestinationComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDestination() {
        RemoveComponent(GameComponentsLookup.Destination);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDestination;

    public static Entitas.IMatcher<GameEntity> Destination {
        get {
            if (_matcherDestination == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Destination);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDestination = matcher;
            }

            return _matcherDestination;
        }
    }
}