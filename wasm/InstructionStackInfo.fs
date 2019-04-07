// this file is automatically generated
module wasm.instr_stack
    open wasm.def_basic
    open wasm.def_instr
    let get_instruction_stack_info op =
        match op with
        | Unreachable -> NoArgs (None)
        | Nop -> NoArgs (None)
        | Block t -> NoArgs t
        | Loop t -> NoArgs t
        | If t -> NoArgs t
        | Else -> NoArgs (None)
        | End -> NoArgs (None)
        | Br _ -> NoArgs (None)
        | BrIf _ -> NoArgs (None)
        | BrTable _ -> NoArgs (None)
        | Return -> NoArgs (None)
        | Call i -> SpecialCaseCall i
        | CallIndirect i -> SpecialCaseCallIndirect i
        | Drop -> SpecialCaseDrop
        | Select -> SpecialCaseSelect
        | LocalGet i -> SpecialCaseLocalGet i
        | LocalSet i -> SpecialCaseLocalSet i
        | LocalTee i -> SpecialCaseLocalTee i
        | GlobalGet i -> SpecialCaseGlobalGet i
        | GlobalSet i -> SpecialCaseGlobalSet i
        | I32Load _ -> OneArg { rtype = Some I32; arg = I32; }
        | I64Load _ -> OneArg { rtype = Some I64; arg = I32; }
        | F32Load _ -> OneArg { rtype = Some F32; arg = I32; }
        | F64Load _ -> OneArg { rtype = Some F64; arg = I32; }
        | I32Load8S _ -> OneArg { rtype = Some I32; arg = I32; }
        | I32Load8U _ -> OneArg { rtype = Some I32; arg = I32; }
        | I32Load16S _ -> OneArg { rtype = Some I32; arg = I32; }
        | I32Load16U _ -> OneArg { rtype = Some I32; arg = I32; }
        | I64Load8S _ -> OneArg { rtype = Some I64; arg = I32; }
        | I64Load8U _ -> OneArg { rtype = Some I64; arg = I32; }
        | I64Load16S _ -> OneArg { rtype = Some I64; arg = I32; }
        | I64Load16U _ -> OneArg { rtype = Some I64; arg = I32; }
        | I64Load32S _ -> OneArg { rtype = Some I64; arg = I32; }
        | I64Load32U _ -> OneArg { rtype = Some I64; arg = I32; }
        | I32Store _ -> TwoArgs { rtype = None; arg1 = I32; arg2 = I32; }
        | I64Store _ -> TwoArgs { rtype = None; arg1 = I32; arg2 = I64; }
        | F32Store _ -> TwoArgs { rtype = None; arg1 = I32; arg2 = F32; }
        | F64Store _ -> TwoArgs { rtype = None; arg1 = I32; arg2 = F64; }
        | I32Store8 _ -> TwoArgs { rtype = None; arg1 = I32; arg2 = I32; }
        | I32Store16 _ -> TwoArgs { rtype = None; arg1 = I32; arg2 = I32; }
        | I64Store8 _ -> TwoArgs { rtype = None; arg1 = I32; arg2 = I64; }
        | I64Store16 _ -> TwoArgs { rtype = None; arg1 = I32; arg2 = I64; }
        | I64Store32 _ -> TwoArgs { rtype = None; arg1 = I32; arg2 = I64; }
        | MemorySize _ -> NoArgs (Some I32)
        | MemoryGrow _ -> OneArg { rtype = Some I32; arg = I32; }
        | I32Const _ -> NoArgs (Some I32)
        | I64Const _ -> NoArgs (Some I64)
        | F32Const _ -> NoArgs (Some F32)
        | F64Const _ -> NoArgs (Some F64)
        | I32Eqz -> OneArg { rtype = Some I32; arg = I32; }
        | I32Eq -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32Ne -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32LtS -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32LtU -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32GtS -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32GtU -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32LeS -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32LeU -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32GeS -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32GeU -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I64Eqz -> OneArg { rtype = Some I32; arg = I64; }
        | I64Eq -> TwoArgs { rtype = Some I32; arg1 = I64; arg2 = I64; }
        | I64Ne -> TwoArgs { rtype = Some I32; arg1 = I64; arg2 = I64; }
        | I64LtS -> TwoArgs { rtype = Some I32; arg1 = I64; arg2 = I64; }
        | I64LtU -> TwoArgs { rtype = Some I32; arg1 = I64; arg2 = I64; }
        | I64GtS -> TwoArgs { rtype = Some I32; arg1 = I64; arg2 = I64; }
        | I64GtU -> TwoArgs { rtype = Some I32; arg1 = I64; arg2 = I64; }
        | I64LeS -> TwoArgs { rtype = Some I32; arg1 = I64; arg2 = I64; }
        | I64LeU -> TwoArgs { rtype = Some I32; arg1 = I64; arg2 = I64; }
        | I64GeS -> TwoArgs { rtype = Some I32; arg1 = I64; arg2 = I64; }
        | I64GeU -> TwoArgs { rtype = Some I32; arg1 = I64; arg2 = I64; }
        | F32Eq -> TwoArgs { rtype = Some I32; arg1 = F32; arg2 = F32; }
        | F32Ne -> TwoArgs { rtype = Some I32; arg1 = F32; arg2 = F32; }
        | F32Lt -> TwoArgs { rtype = Some I32; arg1 = F32; arg2 = F32; }
        | F32Gt -> TwoArgs { rtype = Some I32; arg1 = F32; arg2 = F32; }
        | F32Le -> TwoArgs { rtype = Some I32; arg1 = F32; arg2 = F32; }
        | F32Ge -> TwoArgs { rtype = Some I32; arg1 = F32; arg2 = F32; }
        | F64Eq -> TwoArgs { rtype = Some I32; arg1 = F64; arg2 = F64; }
        | F64Ne -> TwoArgs { rtype = Some I32; arg1 = F64; arg2 = F64; }
        | F64Lt -> TwoArgs { rtype = Some I32; arg1 = F64; arg2 = F64; }
        | F64Gt -> TwoArgs { rtype = Some I32; arg1 = F64; arg2 = F64; }
        | F64Le -> TwoArgs { rtype = Some I32; arg1 = F64; arg2 = F64; }
        | F64Ge -> TwoArgs { rtype = Some I32; arg1 = F64; arg2 = F64; }
        | I32Clz -> OneArg { rtype = Some I32; arg = I32; }
        | I32Ctz -> OneArg { rtype = Some I32; arg = I32; }
        | I32Popcnt -> OneArg { rtype = Some I32; arg = I32; }
        | I32Add -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32Sub -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32Mul -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32DivS -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32DivU -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32RemS -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32RemU -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32And -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32Or -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32Xor -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32Shl -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32ShrS -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32ShrU -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32Rotl -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I32Rotr -> TwoArgs { rtype = Some I32; arg1 = I32; arg2 = I32; }
        | I64Clz -> OneArg { rtype = Some I64; arg = I64; }
        | I64Ctz -> OneArg { rtype = Some I64; arg = I64; }
        | I64Popcnt -> OneArg { rtype = Some I64; arg = I64; }
        | I64Add -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | I64Sub -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | I64Mul -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | I64DivS -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | I64DivU -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | I64RemS -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | I64RemU -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | I64And -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | I64Or -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | I64Xor -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | I64Shl -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | I64ShrS -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | I64ShrU -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | I64Rotl -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | I64Rotr -> TwoArgs { rtype = Some I64; arg1 = I64; arg2 = I64; }
        | F32Abs -> OneArg { rtype = Some F32; arg = F32; }
        | F32Neg -> OneArg { rtype = Some F32; arg = F32; }
        | F32Ceil -> OneArg { rtype = Some F32; arg = F32; }
        | F32Floor -> OneArg { rtype = Some F32; arg = F32; }
        | F32Trunc -> OneArg { rtype = Some F32; arg = F32; }
        | F32Nearest -> OneArg { rtype = Some F32; arg = F32; }
        | F32Sqrt -> OneArg { rtype = Some F32; arg = F32; }
        | F32Add -> TwoArgs { rtype = Some F32; arg1 = F32; arg2 = F32; }
        | F32Sub -> TwoArgs { rtype = Some F32; arg1 = F32; arg2 = F32; }
        | F32Mul -> TwoArgs { rtype = Some F32; arg1 = F32; arg2 = F32; }
        | F32Div -> TwoArgs { rtype = Some F32; arg1 = F32; arg2 = F32; }
        | F32Min -> TwoArgs { rtype = Some F32; arg1 = F32; arg2 = F32; }
        | F32Max -> TwoArgs { rtype = Some F32; arg1 = F32; arg2 = F32; }
        | F32Copysign -> TwoArgs { rtype = Some F32; arg1 = F32; arg2 = F32; }
        | F64Abs -> OneArg { rtype = Some F64; arg = F64; }
        | F64Neg -> OneArg { rtype = Some F64; arg = F64; }
        | F64Ceil -> OneArg { rtype = Some F64; arg = F64; }
        | F64Floor -> OneArg { rtype = Some F64; arg = F64; }
        | F64Trunc -> OneArg { rtype = Some F64; arg = F64; }
        | F64Nearest -> OneArg { rtype = Some F64; arg = F64; }
        | F64Sqrt -> OneArg { rtype = Some F64; arg = F64; }
        | F64Add -> TwoArgs { rtype = Some F64; arg1 = F64; arg2 = F64; }
        | F64Sub -> TwoArgs { rtype = Some F64; arg1 = F64; arg2 = F64; }
        | F64Mul -> TwoArgs { rtype = Some F64; arg1 = F64; arg2 = F64; }
        | F64Div -> TwoArgs { rtype = Some F64; arg1 = F64; arg2 = F64; }
        | F64Min -> TwoArgs { rtype = Some F64; arg1 = F64; arg2 = F64; }
        | F64Max -> TwoArgs { rtype = Some F64; arg1 = F64; arg2 = F64; }
        | F64Copysign -> TwoArgs { rtype = Some F64; arg1 = F64; arg2 = F64; }
        | I32WrapI64 -> OneArg { rtype = Some I32; arg = I64; }
        | I32TruncF32S -> OneArg { rtype = Some I32; arg = F32; }
        | I32TruncF32U -> OneArg { rtype = Some I32; arg = F32; }
        | I32TruncF64S -> OneArg { rtype = Some I32; arg = F64; }
        | I32TruncF64U -> OneArg { rtype = Some I32; arg = F64; }
        | I64ExtendI32S -> OneArg { rtype = Some I64; arg = I32; }
        | I64ExtendI32U -> OneArg { rtype = Some I64; arg = I32; }
        | I64TruncF32S -> OneArg { rtype = Some I64; arg = F32; }
        | I64TruncF32U -> OneArg { rtype = Some I64; arg = F32; }
        | I64TruncF64S -> OneArg { rtype = Some I64; arg = F64; }
        | I64TruncF64U -> OneArg { rtype = Some I64; arg = F64; }
        | F32ConvertI32S -> OneArg { rtype = Some F32; arg = I32; }
        | F32ConvertI32U -> OneArg { rtype = Some F32; arg = I32; }
        | F32ConvertI64S -> OneArg { rtype = Some F32; arg = I64; }
        | F32ConvertI64U -> OneArg { rtype = Some F32; arg = I64; }
        | F32DemoteF64 -> OneArg { rtype = Some F32; arg = F64; }
        | F64ConvertI32S -> OneArg { rtype = Some F64; arg = I32; }
        | F64ConvertI32U -> OneArg { rtype = Some F64; arg = I32; }
        | F64ConvertI64S -> OneArg { rtype = Some F64; arg = I64; }
        | F64ConvertI64U -> OneArg { rtype = Some F64; arg = I64; }
        | F64PromoteF32 -> OneArg { rtype = Some F64; arg = F32; }
        | I32ReinterpretF32 -> OneArg { rtype = Some I32; arg = F32; }
        | I64ReinterpretF64 -> OneArg { rtype = Some I64; arg = F64; }
        | F32ReinterpretI32 -> OneArg { rtype = Some F32; arg = I32; }
        | F64ReinterpretI64 -> OneArg { rtype = Some F64; arg = I64; }

