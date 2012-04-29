﻿using Roslyn.Compilers.CSharp;

namespace LinqToWiki.Codegen.ModuleGenerators
{
    static class ModuleGeneratorRoslynExtensions
    {
        public static ClassDeclarationSyntax WithPrivateConstructor(this ClassDeclarationSyntax selectClass)
        {
            return selectClass.WithAdditionalMembers(
                SyntaxEx.ConstructorDeclaration(new[] { SyntaxKind.PrivateKeyword }, selectClass.Identifier.ValueText));
        }
    }
}