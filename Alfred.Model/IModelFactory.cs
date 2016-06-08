using Alfred.Dal.Entities.Member;
using Alfred.Model.Members;

namespace Alfred.Model
{
    public interface IModelFactory
    {
        Member CreateMember(CreateMemberModel createMemberModel);
        MemberModel CreateMemberModel(Member member);
    }
}
