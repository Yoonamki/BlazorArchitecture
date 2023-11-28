namespace Server.Domain.Core.Primitives;

/// <summary>
/// 파생되는 모든 엔티티의 기본 클래스.
/// </summary>
public abstract class Entity : IEquatable<Entity>
{
    /// <summary>
    /// <see cref="Entity"/> 클래스 개체를 초기화합니다.
    /// </summary>
    /// <param name="id">엔티티 식별자.</param>
    protected Entity(Guid id)
        : this()
    {
        Id = id;
    }

    /// <summary>
    /// <see cref="Entity"/> 클래스 개체를 초기화합니다.
    /// </summary>
    /// <remarks>
    /// Required by EF Core.
    /// </remarks>
    protected Entity()
    {
    }

    /// <summary>
    /// 엔티티 식별자를 가져오거나 설정합니다.
    /// </summary>
    public Guid Id { get; private set; }

    public static bool operator ==(Entity a, Entity b)
    {
        if (a is null && b is null)
        {
            return true;
        }

        if (a is null || b is null)
        {
            return false;
        }

        return a.Equals(b);
    }

    public static bool operator !=(Entity a, Entity b) => !(a == b);

    /// <inheritdoc />
    public bool Equals(Entity other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other) || Id == other.Id;
    }

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        if (!(obj is Entity other))
        {
            return false;
        }

        if (Id == Guid.Empty || other.Id == Guid.Empty)
        {
            return false;
        }

        return Id == other.Id;
    }

    /// <inheritdoc />
    public override int GetHashCode() => Id.GetHashCode() * 41;
}
