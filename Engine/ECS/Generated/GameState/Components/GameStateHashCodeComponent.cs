//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateContext {

    public GameStateEntity hashCodeEntity { get { return GetGroup(GameStateMatcher.HashCode).GetSingleEntity(); } }
    public HashCodeComponent hashCode { get { return hashCodeEntity.hashCode; } }
    public bool hasHashCode { get { return hashCodeEntity != null; } }

    public GameStateEntity SetHashCode(long newValue) {
        if (hasHashCode) {
            throw new Entitas.EntitasException("Could not set HashCode!\n" + this + " already has an entity with HashCodeComponent!",
                "You should check if the context already has a hashCodeEntity before setting it or use context.ReplaceHashCode().");
        }
        var entity = CreateEntity();
        entity.AddHashCode(newValue);
        return entity;
    }

    public void ReplaceHashCode(long newValue) {
        var entity = hashCodeEntity;
        if (entity == null) {
            entity = SetHashCode(newValue);
        } else {
            entity.ReplaceHashCode(newValue);
        }
    }

    public void RemoveHashCode() {
        hashCodeEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public HashCodeComponent hashCode { get { return (HashCodeComponent)GetComponent(GameStateComponentsLookup.HashCode); } }
    public bool hasHashCode { get { return HasComponent(GameStateComponentsLookup.HashCode); } }

    public void AddHashCode(long newValue) {
        var index = GameStateComponentsLookup.HashCode;
        var component = (HashCodeComponent)CreateComponent(index, typeof(HashCodeComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceHashCode(long newValue) {
        var index = GameStateComponentsLookup.HashCode;
        var component = (HashCodeComponent)CreateComponent(index, typeof(HashCodeComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveHashCode() {
        RemoveComponent(GameStateComponentsLookup.HashCode);
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
public sealed partial class GameStateMatcher {

    static Entitas.IMatcher<GameStateEntity> _matcherHashCode;

    public static Entitas.IMatcher<GameStateEntity> HashCode {
        get {
            if (_matcherHashCode == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.HashCode);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherHashCode = matcher;
            }

            return _matcherHashCode;
        }
    }
}
