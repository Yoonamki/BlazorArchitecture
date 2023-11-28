namespace Server.Domain.Core.Abstractions;

/// <summary>
/// 삭제가능한 엔티티를 나타내는 인터페이스.
/// </summary>
public interface IDeletableEntity
{
    /// <summary>
    /// UTC 형식의 삭제 일자를 가져온다.
    /// </summary>
    DateTime? DeletedOnUtc { get; }

    /// <summary>
    /// 엔티티가 삭제되었는지 나타내는 값을 가져온다.
    /// </summary>
    bool? IsDeleted { get; }
}
