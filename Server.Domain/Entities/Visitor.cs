using Server.Domain.Core.Abstractions;
using Server.Domain.Core.Primitives;

namespace Server.Domain.Entities;

/// <summary>
/// 방문객 정보를 나타냅니다.
/// </summary>
public sealed class Visitor : Entity, IAuditableEntity
{
    /// <summary>
    /// <see cref="Visitor"/> 클래스의 개체를 초기화합니다.
    /// </summary>
    public Visitor()
        : base(Guid.NewGuid())
    {
    }

    /// <summary>
    /// 이름을 가져오거나 설정합니다.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 휴대폰번호를 가져오거나 설정합니다.
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// 생년월일을 가져오거나 설정합니다.
    /// </summary>
    public DateTime Birthday { get; set; }

    /// <summary>
    /// 차량번호를 가져오거나 설정합니다.
    /// </summary>
    public string? VehicleNumber { get; set; }

    /// <inheritdoc />
    public DateTime CreatedOnUtc { get; }

    /// <inheritdoc />
    public DateTime? UpdatedOnUtc { get; }
}
