//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Intrinsic.Interfaces;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"CyclicalDemo\",\"Name\":\"P\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Empty\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":12}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":14},\"Item2\":{\"Line\":1,\"Column\":22}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"CyclicalDemo\",\"Name\":\"P\"},\"Attributes\":[],\"SourceFile\":\"/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":12}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"CyclicalDemo\",\"Name\":\"P\"},\"Attributes\":[],\"SourceFile\":\"/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":52}},\"Documentation\":[\"automatically generated QsAdjoint specialization for CyclicalDemo.P\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"CyclicalDemo\",\"Name\":\"P\"},\"Attributes\":[],\"SourceFile\":\"/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":52}},\"Documentation\":[\"automatically generated QsControlled specialization for CyclicalDemo.P\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"CyclicalDemo\",\"Name\":\"P\"},\"Attributes\":[],\"SourceFile\":\"/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":52}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for CyclicalDemo.P\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"CyclicalDemo\",\"Name\":\"U0\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Empty\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs\",\"Position\":{\"Item1\":25,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":13}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"theta\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"CyclicalDemo\",\"Name\":\"U0\"},\"Attributes\":[],\"SourceFile\":\"/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs\",\"Position\":{\"Item1\":25,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":13}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"CyclicalDemo\",\"Name\":\"U1\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Empty\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":13}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"theta\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"CyclicalDemo\",\"Name\":\"U1\"},\"Attributes\":[],\"SourceFile\":\"/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":13}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"CyclicalDemo\",\"Name\":\"U\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Empty\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs\",\"Position\":{\"Item1\":40,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":12}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":14},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"theta\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"CyclicalDemo\",\"Name\":\"U\"},\"Attributes\":[],\"SourceFile\":\"/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs\",\"Position\":{\"Item1\":40,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":12}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"CyclicalDemo\",\"Name\":\"RunWalk\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Transparent\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numQubits\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"steps\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"CyclicalDemo\",\"Name\":\"RunWalk\"},\"Attributes\":[],\"SourceFile\":\"/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
#line hidden
namespace CyclicalDemo
{
    [SourceLocation("/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs", OperationFunctor.Body, 11, 26)]
    [SourceLocation("/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs", OperationFunctor.Adjoint, 11, 26)]
    [SourceLocation("/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs", OperationFunctor.Controlled, 11, 26)]
    [SourceLocation("/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs", OperationFunctor.ControlledAdjoint, 11, 26)]
    public partial class P : Unitary<IQArray<Qubit>>, ICallable
    {
        public P(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "P";
        String ICallable.FullName => "CyclicalDemo.P";
        protected ICallable Length__
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected ICallable<QRange, QRange> RangeReverse__
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> __Body__ => (__in__) =>
        {
            var register = __in__;
#line 13 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
            var size = register.Length;
#line 15 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
            foreach (var i in new QRange(0L, (size - 1L)))
#line hidden
            {
#line 16 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                if ((i == (size - 1L)))
                {
#line 17 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                    Microsoft__Quantum__Intrinsic__X.Apply(register[i]);
                }
                else
                {
#line 20 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                    Microsoft__Quantum__Intrinsic__X.Controlled.Apply((register.Slice(new QRange((i + 1L), (size - 1L))), register[i]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> __AdjointBody__ => (__in__) =>
        {
            var register = __in__;
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
            var __qsVar0__size__ = register.Length;
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
            foreach (var __qsVar1__i__ in RangeReverse__.Apply(new QRange(0L, (__qsVar0__size__ - 1L))))
#line hidden
            {
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                if ((__qsVar1__i__ == (__qsVar0__size__ - 1L)))
                {
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                    Microsoft__Quantum__Intrinsic__X.Adjoint.Apply(register[__qsVar1__i__]);
                }
                else
                {
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                    Microsoft__Quantum__Intrinsic__X.Controlled.Adjoint.Apply((register.Slice(new QRange((__qsVar1__i__ + 1L), (__qsVar0__size__ - 1L))), register[__qsVar1__i__]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> __ControlledBody__ => (__in__) =>
        {
            var (__controlQubits__,register) = __in__;
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
            var size = register.Length;
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
            foreach (var i in new QRange(0L, (size - 1L)))
#line hidden
            {
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                if ((i == (size - 1L)))
                {
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                    Microsoft__Quantum__Intrinsic__X.Controlled.Apply((__controlQubits__, register[i]));
                }
                else
                {
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                    Microsoft__Quantum__Intrinsic__X.Controlled.Controlled.Apply((__controlQubits__, (register.Slice(new QRange((i + 1L), (size - 1L))), register[i])));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> __ControlledAdjointBody__ => (__in__) =>
        {
            var (__controlQubits__,register) = __in__;
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
            var __qsVar0__size__ = register.Length;
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
            foreach (var __qsVar1__i__ in RangeReverse__.Apply(new QRange(0L, (__qsVar0__size__ - 1L))))
#line hidden
            {
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                if ((__qsVar1__i__ == (__qsVar0__size__ - 1L)))
                {
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                    Microsoft__Quantum__Intrinsic__X.Adjoint.Controlled.Apply((__controlQubits__, register[__qsVar1__i__]));
                }
                else
                {
#line 11 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                    Microsoft__Quantum__Intrinsic__X.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (register.Slice(new QRange((__qsVar1__i__ + 1L), (__qsVar0__size__ - 1L))), register[__qsVar1__i__])));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.RangeReverse__ = this.__Factory__.Get<ICallable<QRange, QRange>>(typeof(global::Microsoft.Quantum.Core.RangeReverse));
        }

        public override IApplyData __DataIn__(IQArray<Qubit> data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register)
        {
            return __m__.Run<P, IQArray<Qubit>, QVoid>(register);
        }
    }

    [SourceLocation("/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs", OperationFunctor.Body, 26, 33)]
    public partial class U0 : Operation<(IQArray<Qubit>,Double), QVoid>, ICallable
    {
        public U0(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Double)>, IApplyData
        {
            public In((IQArray<Qubit>,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    return ((IApplyData)Data.Item1)?.Qubits;
                }
            }
        }

        String ICallable.Name => "U0";
        String ICallable.FullName => "CyclicalDemo.U0";
        protected IUnitary<(Double,Qubit)> Microsoft__Quantum__Intrinsic__Rx
        {
            get;
            set;
        }

        protected ICallable Length__
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Double), QVoid> __Body__ => (__in__) =>
        {
            var (register,theta) = __in__;
#line 28 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
            Microsoft__Quantum__Intrinsic__Rx.Apply(((2D * theta), register[(register.Length - 1L)]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Intrinsic__Rx = this.__Factory__.Get<IUnitary<(Double,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.Rx));
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __DataIn__((IQArray<Qubit>,Double) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register, Double theta)
        {
            return __m__.Run<U0, (IQArray<Qubit>,Double), QVoid>((register, theta));
        }
    }

    [SourceLocation("/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs", OperationFunctor.Body, 33, 41)]
    public partial class U1 : Operation<(IQArray<Qubit>,Double), QVoid>, ICallable
    {
        public U1(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Double)>, IApplyData
        {
            public In((IQArray<Qubit>,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    return ((IApplyData)Data.Item1)?.Qubits;
                }
            }
        }

        String ICallable.Name => "U1";
        String ICallable.FullName => "CyclicalDemo.U1";
        protected IUnitary<IQArray<Qubit>> P__
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Double), QVoid> U0__
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Double), QVoid> __Body__ => (__in__) =>
        {
            var (register,theta) = __in__;
#line 35 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
            P__.Apply(register);
#line 36 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
            U0__.Apply((register, theta));
#line 37 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
            P__.Adjoint.Apply(register);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.P__ = this.__Factory__.Get<IUnitary<IQArray<Qubit>>>(typeof(P));
            this.U0__ = this.__Factory__.Get<ICallable<(IQArray<Qubit>,Double), QVoid>>(typeof(U0));
        }

        public override IApplyData __DataIn__((IQArray<Qubit>,Double) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register, Double theta)
        {
            return __m__.Run<U1, (IQArray<Qubit>,Double), QVoid>((register, theta));
        }
    }

    [SourceLocation("/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs", OperationFunctor.Body, 41, 49)]
    public partial class U : Operation<(IQArray<Qubit>,Double), QVoid>, ICallable
    {
        public U(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Double)>, IApplyData
        {
            public In((IQArray<Qubit>,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    return ((IApplyData)Data.Item1)?.Qubits;
                }
            }
        }

        String ICallable.Name => "U";
        String ICallable.FullName => "CyclicalDemo.U";
        protected ICallable<(IQArray<Qubit>,Double), QVoid> U1__
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Double), QVoid> U0__
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Double), QVoid> __Body__ => (__in__) =>
        {
            var (register,theta) = __in__;
#line 43 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
            U1__.Apply((register, theta));
#line 44 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
            U0__.Apply((register, theta));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.U1__ = this.__Factory__.Get<ICallable<(IQArray<Qubit>,Double), QVoid>>(typeof(U1));
            this.U0__ = this.__Factory__.Get<ICallable<(IQArray<Qubit>,Double), QVoid>>(typeof(U0));
        }

        public override IApplyData __DataIn__((IQArray<Qubit>,Double) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register, Double theta)
        {
            return __m__.Run<U, (IQArray<Qubit>,Double), QVoid>((register, theta));
        }
    }

    [SourceLocation("/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs", OperationFunctor.Body, 49, -1)]
    public partial class RunWalk : Operation<(Int64,Int64), Int64>, ICallable
    {
        public RunWalk(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "RunWalk";
        String ICallable.FullName => "CyclicalDemo.RunWalk";
        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Double), QVoid> U__
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> Microsoft__Quantum__Math__PI
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Intrinsic__M
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), Int64> __Body__ => (__in__) =>
        {
            var (numQubits,steps) = __in__;
#line hidden
            {
#line 51 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                var register = Allocate__.Apply(numQubits);
#line hidden
                bool __arg1__ = true;
                try
                {
#line 52 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                    foreach (var i in new QRange(1L, steps))
#line hidden
                    {
#line 53 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                        U__.Apply((register, (Microsoft__Quantum__Math__PI.Apply(QVoid.Instance) / 8D)));
                    }

#line 56 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                    var sum = 0L;
#line 57 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                    foreach (var i in new QRange(0L, (numQubits - 1L)))
#line hidden
                    {
#line 58 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                        sum = (sum + (2L.Pow(i) * ((Microsoft__Quantum__Intrinsic__M.Apply(register[i]) == Result.One) ? 1L : 0L)));
                    }

#line 61 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                    Message__.Apply(String.Format("Walker moved from position 0 to position {0} in {1} steps.", sum, steps));
#line 63 "/Users/2019omatheson/Desktop/final_project/QuantumWalks/CyclicalDemo.qs"
                    return sum;
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(register);
                    }
                }
            }
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.U__ = this.__Factory__.Get<ICallable<(IQArray<Qubit>,Double), QVoid>>(typeof(U));
            this.Microsoft__Quantum__Math__PI = this.__Factory__.Get<ICallable<QVoid, Double>>(typeof(global::Microsoft.Quantum.Math.PI));
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
        }

        public override IApplyData __DataIn__((Int64,Int64) data) => new In(data);
        public override IApplyData __DataOut__(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 numQubits, Int64 steps)
        {
            return __m__.Run<RunWalk, (Int64,Int64), Int64>((numQubits, steps));
        }
    }
}