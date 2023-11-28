namespace Server.Domain.Core.Abstractions;

/// <summary>
/// 감사 엔티티를 나타내는 인터페이스.
/// </summary>
public interface IAuditableEntity
{
    /// <summary>
    /// UTC 형식의 생성 일자를 가져온다.
    /// </summary>
    DateTime CreatedOnUtc { get; }

    /// <summary>
    /// UTC 형식의 수정 일자를 가져온다.
    /// </summary>
    DateTime? UpdatedOnUtc { get; }
}
