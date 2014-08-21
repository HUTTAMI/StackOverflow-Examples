This directory oinly exists for demonstration purposes (without incurring liability).

In a real implementation each project should include the appropriate Sitecore DLLs
that reflect the version its targeting (e.g. Sitecore.Kernel.dll, Sitecore.CLient.dll,
etc)

Also, each new project should target the same namespace (to keep consistency), but also
include a debug symbol for that version (for shared files). Basically:

1. Create a new project for the different Sitecore version
2. Open the project's properties
3. Change the default namespace to your common namespace (here I've used "MyCompany")
4. Add a Debug symbol for that version (synonymous with the project name suffix).