﻿if ($PSEdition -eq 'Desktop') {
  try {
    [Microsoft.Azure.Commands.Profile.Utilities.CustomAssemblyResolver]::Initialize()
  }
  catch {
    Write-Warning $_
  }
}
else {
  try {
    $assemblyLoadContextFolder = [System.IO.Path]::Combine($PSScriptRoot, "..", "AzSharedAlcAssemblies")
    Write-Debug "Registering Az shared AssemblyLoadContext for path: '$assemblyLoadContextFolder'."
    [Microsoft.Azure.PowerShell.AuthenticationAssemblyLoadContext.AzAssemblyLoadContextInitializer]::RegisterAzSharedAssemblyLoadContext($assemblyLoadContextFolder)
    Write-Debug "AssemblyLoadContext registered."
  }
  catch {
    Write-Warning $_
  }
}