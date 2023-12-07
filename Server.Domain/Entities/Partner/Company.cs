using Server.Domain.Core.Abstractions;
using Server.Domain.Core.Primitives;

namespace Server.Domain.Entities.Partner;

public sealed class Company : Entity, IAuditableEntity
{
    /// <summary>
    /// <see cref="Company"/> 클래스의 개체를 초기화합니다.
    /// </summary>
    public Company()
        : base(Guid.NewGuid())
    {
    }

    /// <summary>
    /// 회사명을 가져오거나 설정합니다.
    /// </summary>
    public string CompanyName { get; set; }

    /// <summary>
    /// 사업자등록번호를 가져오거나 설정합니다.
    /// </summary>
    public string RegistrationNumber { get; set; }

    /// <summary>
    /// 대표자 이메일을 가져오거나 설정합니다.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// 주소를 가져오거나 설정합니다.
    /// </summary>
    public string Address { get; set; }

    /// <inheritdoc />
    public DateTime CreatedOnUtc { get; set; }

    /// <inheritdoc />
    public DateTime? UpdatedOnUtc { get; set; }
}
