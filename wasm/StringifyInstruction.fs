// this file is automatically generated
module wasm.stringify_instr
    open wasm.def_instr
    open wasm.stringify_args
    let stringify_instruction op =
        match op with
        | Unreachable -> "unreachable"
        | Nop -> "nop"
        | Block i -> sprintf "block %u" i
        | Loop i -> sprintf "loop %u" i
        | If i -> sprintf "if %u" i
        | Else -> "else"
        | End -> "end"
        | Br i -> sprintf "br %u" i
        | BrIf i -> sprintf "br_if %u" i
        | BrTable i -> sprintf "br_table %s" (stringify_brtable i)
        | Return -> "return"
        | Call i -> sprintf "call %u" i
        | CallIndirect i -> sprintf "call_indirect %s" (stringify_callindirect i)
        | Drop -> "drop"
        | Select -> "select"
        | LocalGet i -> sprintf "local.get %u" i
        | LocalSet i -> sprintf "local.set %u" i
        | LocalTee i -> sprintf "local.tee %u" i
        | GlobalGet i -> sprintf "global.get %u" i
        | GlobalSet i -> sprintf "global.set %u" i
        | I32Load i -> sprintf "i32.load %s" (stringify_memarg i)
        | I64Load i -> sprintf "i64.load %s" (stringify_memarg i)
        | F32Load i -> sprintf "f32.load %s" (stringify_memarg i)
        | F64Load i -> sprintf "f64.load %s" (stringify_memarg i)
        | I32Load8S i -> sprintf "i32.load8_s %s" (stringify_memarg i)
        | I32Load8U i -> sprintf "i32.load8_u %s" (stringify_memarg i)
        | I32Load16S i -> sprintf "i32.load16_s %s" (stringify_memarg i)
        | I32Load16U i -> sprintf "i32.load16_u %s" (stringify_memarg i)
        | I64Load8S i -> sprintf "i64.load8_s %s" (stringify_memarg i)
        | I64Load8U i -> sprintf "i64.load8_u %s" (stringify_memarg i)
        | I64Load16S i -> sprintf "i64.load16_s %s" (stringify_memarg i)
        | I64Load16U i -> sprintf "i64.load16_u %s" (stringify_memarg i)
        | I64Load32S i -> sprintf "i64.load32_s %s" (stringify_memarg i)
        | I64Load32U i -> sprintf "i64.load32_u %s" (stringify_memarg i)
        | I32Store i -> sprintf "i32.store %s" (stringify_memarg i)
        | I64Store i -> sprintf "i64.store %s" (stringify_memarg i)
        | F32Store i -> sprintf "f32.store %s" (stringify_memarg i)
        | F64Store i -> sprintf "f64.store %s" (stringify_memarg i)
        | I32Store8 i -> sprintf "i32.store8 %s" (stringify_memarg i)
        | I32Store16 i -> sprintf "i32.store16 %s" (stringify_memarg i)
        | I64Store8 i -> sprintf "i64.store8 %s" (stringify_memarg i)
        | I64Store16 i -> sprintf "i64.store16 %s" (stringify_memarg i)
        | I64Store32 i -> sprintf "i64.store32 %s" (stringify_memarg i)
        | MemorySize i -> sprintf "memory.size %u" i
        | MemoryGrow i -> sprintf "memory.grow %u" i
        | I32Const i -> sprintf "i32.const %d" i
        | I64Const i -> sprintf "i64.const %d" i
        | F32Const i -> sprintf "f32.const %f" i
        | F64Const i -> sprintf "f64.const %f" i
        | I32Eqz -> "i32.eqz"
        | I32Eq -> "i32.eq"
        | I32Ne -> "i32.ne"
        | I32LtS -> "i32.lt_s"
        | I32LtU -> "i32.lt_u"
        | I32GtS -> "i32.gt_s"
        | I32GtU -> "i32.gt_u"
        | I32LeS -> "i32.le_s"
        | I32LeU -> "i32.le_u"
        | I32GeS -> "i32.ge_s"
        | I32GeU -> "i32.ge_u"
        | I64Eqz -> "i64.eqz"
        | I64Eq -> "i64.eq"
        | I64Ne -> "i64.ne"
        | I64LtS -> "i64.lt_s"
        | I64LtU -> "i64.lt_u"
        | I64GtS -> "i64.gt_s"
        | I64GtU -> "i64.gt_u"
        | I64LeS -> "i64.le_s"
        | I64LeU -> "i64.le_u"
        | I64GeS -> "i64.ge_s"
        | I64GeU -> "i64.ge_u"
        | F32Eq -> "f32.eq"
        | F32Ne -> "f32.ne"
        | F32Lt -> "f32.lt"
        | F32Gt -> "f32.gt"
        | F32Le -> "f32.le"
        | F32Ge -> "f32.ge"
        | F64Eq -> "f64.eq"
        | F64Ne -> "f64.ne"
        | F64Lt -> "f64.lt"
        | F64Gt -> "f64.gt"
        | F64Le -> "f64.le"
        | F64Ge -> "f64.ge"
        | I32Clz -> "i32.clz"
        | I32Ctz -> "i32.ctz"
        | I32Popcnt -> "i32.popcnt"
        | I32Add -> "i32.add"
        | I32Sub -> "i32.sub"
        | I32Mul -> "i32.mul"
        | I32DivS -> "i32.div_s"
        | I32DivU -> "i32.div_u"
        | I32RemS -> "i32.rem_s"
        | I32RemU -> "i32.rem_u"
        | I32And -> "i32.and"
        | I32Or -> "i32.or"
        | I32Xor -> "i32.xor"
        | I32Shl -> "i32.shl"
        | I32ShrS -> "i32.shr_s"
        | I32ShrU -> "i32.shr_u"
        | I32Rotl -> "i32.rotl"
        | I32Rotr -> "i32.rotr"
        | I64Clz -> "i64.clz"
        | I64Ctz -> "i64.ctz"
        | I64Popcnt -> "i64.popcnt"
        | I64Add -> "i64.add"
        | I64Sub -> "i64.sub"
        | I64Mul -> "i64.mul"
        | I64DivS -> "i64.div_s"
        | I64DivU -> "i64.div_u"
        | I64RemS -> "i64.rem_s"
        | I64RemU -> "i64.rem_u"
        | I64And -> "i64.and"
        | I64Or -> "i64.or"
        | I64Xor -> "i64.xor"
        | I64Shl -> "i64.shl"
        | I64ShrS -> "i64.shr_s"
        | I64ShrU -> "i64.shr_u"
        | I64Rotl -> "i64.rotl"
        | I64Rotr -> "i64.rotr"
        | F32Abs -> "f32.abs"
        | F32Neg -> "f32.neg"
        | F32Ceil -> "f32.ceil"
        | F32Floor -> "f32.floor"
        | F32Trunc -> "f32.trunc"
        | F32Nearest -> "f32.nearest"
        | F32Sqrt -> "f32.sqrt"
        | F32Add -> "f32.add"
        | F32Sub -> "f32.sub"
        | F32Mul -> "f32.mul"
        | F32Div -> "f32.div"
        | F32Min -> "f32.min"
        | F32Max -> "f32.max"
        | F32Copysign -> "f32.copysign"
        | F64Abs -> "f64.abs"
        | F64Neg -> "f64.neg"
        | F64Ceil -> "f64.ceil"
        | F64Floor -> "f64.floor"
        | F64Trunc -> "f64.trunc"
        | F64Nearest -> "f64.nearest"
        | F64Sqrt -> "f64.sqrt"
        | F64Add -> "f64.add"
        | F64Sub -> "f64.sub"
        | F64Mul -> "f64.mul"
        | F64Div -> "f64.div"
        | F64Min -> "f64.min"
        | F64Max -> "f64.max"
        | F64Copysign -> "f64.copysign"
        | I32WrapI64 -> "i32.wrap_i64"
        | I32TruncF32S -> "i32.trunc_f32_s"
        | I32TruncF32U -> "i32.trunc_f32_u"
        | I32TruncF64S -> "i32.trunc_f64_s"
        | I32TruncF64U -> "i32.trunc_f64_u"
        | I64ExtendI32S -> "i64.extend_i32_s"
        | I64ExtendI32U -> "i64.extend_i32_u"
        | I64TruncF32S -> "i64.trunc_f32_s"
        | I64TruncF32U -> "i64.trunc_f32_u"
        | I64TruncF64S -> "i64.trunc_f64_s"
        | I64TruncF64U -> "i64.trunc_f64_u"
        | F32ConvertI32S -> "f32.convert_i32_s"
        | F32ConvertI32U -> "f32.convert_i32_u"
        | F32ConvertI64S -> "f32.convert_i64_s"
        | F32ConvertI64U -> "f32.convert_i64_u"
        | F32DemoteF64 -> "f32.demote_f64"
        | F64ConvertI32S -> "f64.convert_i32_s"
        | F64ConvertI32U -> "f64.convert_i32_u"
        | F64ConvertI64S -> "f64.convert_i64_s"
        | F64ConvertI64U -> "f64.convert_i64_u"
        | F64PromoteF32 -> "f64.promote_f32"
        | I32ReinterpretF32 -> "i32.reinterpret_f32"
        | I64ReinterpretF64 -> "i64.reinterpret_f64"
        | F32ReinterpretI32 -> "f32.reinterpret_i32"
        | F64ReinterpretI64 -> "f64.reinterpret_i64"

