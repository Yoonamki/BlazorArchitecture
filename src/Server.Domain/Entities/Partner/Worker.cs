using Server.Domain.Core.Abstractions;
using Server.Domain.Core.Primitives;

namespace Server.Domain.Entities.Partner;

public sealed class Worker : Entity, IAuditableEntity
{
    /// <summary>
    /// <see cref="Worker"/> 클래스의 개체를 초기화합니다.
    /// </summary>
    public Worker()
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
    public string Phone {  get; set; }

    /// <summary>
    /// 생년월일을 가져오거나 설정합니다.
    /// </summary>
    public DateTime Birthday { get; set; }

    /// <inheritdoc/>
    public DateTime CreatedOnUtc { get; set; }

    /// <inheritdoc/>
    public DateTime? UpdatedOnUtc { get; set; }

    public Company Company { get; set; }
}
