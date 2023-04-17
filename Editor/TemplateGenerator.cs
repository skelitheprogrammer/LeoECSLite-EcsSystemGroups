using UnityEditor;

namespace Skillitronic.LeoECSLite.Common.Editor
{
    internal sealed partial class TemplateGenerator
    {
        private const string TEMPLATE_SYSTEM_GROUPS = "TemplateSystemGroup.cs.txt";

        [MenuItem("Assets/Create/LeoECS Lite/SystemGroups/Create System Group", false, -199)]
        private static void CreateSystemGroupsTemplate()
        {
            CreateAndRenameAsset($"{GetAssetPath()}/EntityDescriptor.cs", GetIcon(),
                (name) => CreateTemplateInternal(GetTemplateContent(TEMPLATE_SYSTEM_GROUPS), name));
        }
    }
}