// An interface with a default implementation of a property
public interface INamed
{
    int Id { get; }
    string Name => $"{this.GetType()}: {this.Id}";

}