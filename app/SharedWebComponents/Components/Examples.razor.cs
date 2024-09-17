// Copyright (c) Microsoft. All rights reserved.

namespace SharedWebComponents.Components;

public sealed partial class Examples
{
    [Parameter, EditorRequired] public required string Message { get; set; }
    [Parameter, EditorRequired] public EventCallback<string> OnExampleClicked { get; set; }

    private string WhatIsIncluded { get; } = "¿Quién tiene experiencia en .NET o C# y ha trabajado en el sector bancario?";
    private string WhatIsPerfReview { get; } = "¿Qué candidatos podrían aplicar a una posición de QA Automatizado Senior para Banco de Guayaquil?";
    private string WhatDoesPmDo { get; } = "¿Hay algun candidato con más de 3 años de experiencia en Java?";

    private async Task OnClickedAsync(string exampleText)
    {
        if (OnExampleClicked.HasDelegate)
        {
            await OnExampleClicked.InvokeAsync(exampleText);
        }
    }
}
