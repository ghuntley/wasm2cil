// this file is automatically generated
module wasm.read_instr
    open wasm.buffer
    open wasm.instr
    open wasm.read_args
    let read_instruction (br: BinaryWasmStream) =
        let b1 = br.ReadByte()
        match b1 with
        | 0x00uy -> Unreachable
        | 0x01uy -> Nop
        | 0x02uy -> Block (br.ReadByte())
        | 0x03uy -> Loop (br.ReadByte())
        | 0x04uy -> If (br.ReadByte())
        | 0x05uy -> Else
        | 0x0buy -> End
        | 0x0cuy -> Br (br.ReadVarUInt32())
        | 0x0duy -> BrIf (br.ReadVarUInt32())
        | 0x0euy -> BrTable (read_brtable br)
        | 0x0fuy -> Return
        | 0x10uy -> Call (br.ReadVarUInt32())
        | 0x11uy -> CallIndirect (read_callindirect br)
        | 0x1auy -> Drop
        | 0x1buy -> Select
        | 0x20uy -> LocalGet (br.ReadVarUInt32())
        | 0x21uy -> LocalSet (br.ReadVarUInt32())
        | 0x22uy -> LocalTee (br.ReadVarUInt32())
        | 0x23uy -> GlobalGet (br.ReadVarUInt32())
        | 0x24uy -> GlobalSet (br.ReadVarUInt32())
        | 0x28uy -> I32Load (read_memarg br)
        | 0x29uy -> I64Load (read_memarg br)
        | 0x2auy -> F32Load (read_memarg br)
        | 0x2buy -> F64Load (read_memarg br)
        | 0x2cuy -> I32Load8S (read_memarg br)
        | 0x2duy -> I32Load8U (read_memarg br)
        | 0x2euy -> I32Load16S (read_memarg br)
        | 0x2fuy -> I32Load16U (read_memarg br)
        | 0x30uy -> I64Load8S (read_memarg br)
        | 0x31uy -> I64Load8U (read_memarg br)
        | 0x32uy -> I64Load16S (read_memarg br)
        | 0x33uy -> I64Load16U (read_memarg br)
        | 0x34uy -> I64Load32S (read_memarg br)
        | 0x35uy -> I64Load32U (read_memarg br)
        | 0x36uy -> I32Store (read_memarg br)
        | 0x37uy -> I64Store (read_memarg br)
        | 0x38uy -> F32Store (read_memarg br)
        | 0x39uy -> F64Store (read_memarg br)
        | 0x3auy -> I32Store8 (read_memarg br)
        | 0x3buy -> I32Store16 (read_memarg br)
        | 0x3cuy -> I64Store8 (read_memarg br)
        | 0x3duy -> I64Store16 (read_memarg br)
        | 0x3euy -> I64Store32 (read_memarg br)
        | 0x3fuy -> MemorySize (br.ReadByte())
        | 0x40uy -> MemoryGrow (br.ReadByte())
        | 0x41uy -> I32Const (br.ReadVarInt32())
        | 0x42uy -> I64Const (br.ReadVarInt64())
        | 0x43uy -> F32Const (br.ReadFloat32())
        | 0x44uy -> F64Const (br.ReadFloat64())
        | 0x45uy -> I32Eqz
        | 0x46uy -> I32Eq
        | 0x47uy -> I32Ne
        | 0x48uy -> I32LtS
        | 0x49uy -> I32LtU
        | 0x4auy -> I32GtS
        | 0x4buy -> I32GtU
        | 0x4cuy -> I32LeS
        | 0x4duy -> I32LeU
        | 0x4euy -> I32GeS
        | 0x4fuy -> I32GeU
        | 0x50uy -> I64Eqz
        | 0x51uy -> I64Eq
        | 0x52uy -> I64Ne
        | 0x53uy -> I64LtS
        | 0x54uy -> I64LtU
        | 0x55uy -> I64GtS
        | 0x56uy -> I64GtU
        | 0x57uy -> I64LeS
        | 0x58uy -> I64LeU
        | 0x59uy -> I64GeS
        | 0x5auy -> I64GeU
        | 0x5buy -> F32Eq
        | 0x5cuy -> F32Ne
        | 0x5duy -> F32Lt
        | 0x5euy -> F32Gt
        | 0x5fuy -> F32Le
        | 0x60uy -> F32Ge
        | 0x61uy -> F64Eq
        | 0x62uy -> F64Ne
        | 0x63uy -> F64Lt
        | 0x64uy -> F64Gt
        | 0x65uy -> F64Le
        | 0x66uy -> F64Ge
        | 0x67uy -> I32Clz
        | 0x68uy -> I32Ctz
        | 0x69uy -> I32Popcnt
        | 0x6auy -> I32Add
        | 0x6buy -> I32Sub
        | 0x6cuy -> I32Mul
        | 0x6duy -> I32DivS
        | 0x6euy -> I32DivU
        | 0x6fuy -> I32RemS
        | 0x70uy -> I32RemU
        | 0x71uy -> I32And
        | 0x72uy -> I32Or
        | 0x73uy -> I32Xor
        | 0x74uy -> I32Shl
        | 0x75uy -> I32ShrS
        | 0x76uy -> I32ShrU
        | 0x77uy -> I32Rotl
        | 0x78uy -> I32Rotr
        | 0x79uy -> I64Clz
        | 0x7auy -> I64Ctz
        | 0x7buy -> I64Popcnt
        | 0x7cuy -> I64Add
        | 0x7duy -> I64Sub
        | 0x7euy -> I64Mul
        | 0x7fuy -> I64DivS
        | 0x80uy -> I64DivU
        | 0x81uy -> I64RemS
        | 0x82uy -> I64RemU
        | 0x83uy -> I64And
        | 0x84uy -> I64Or
        | 0x85uy -> I64Xor
        | 0x86uy -> I64Shl
        | 0x87uy -> I64ShrS
        | 0x88uy -> I64ShrU
        | 0x89uy -> I64Rotl
        | 0x8auy -> I64Rotr
        | 0x8buy -> F32Abs
        | 0x8cuy -> F32Neg
        | 0x8duy -> F32Ceil
        | 0x8euy -> F32Floor
        | 0x8fuy -> F32Trunc
        | 0x90uy -> F32Nearest
        | 0x91uy -> F32Sqrt
        | 0x92uy -> F32Add
        | 0x93uy -> F32Sub
        | 0x94uy -> F32Mul
        | 0x95uy -> F32Div
        | 0x96uy -> F32Min
        | 0x97uy -> F32Max
        | 0x98uy -> F32Copysign
        | 0x99uy -> F64Abs
        | 0x9auy -> F64Neg
        | 0x9buy -> F64Ceil
        | 0x9cuy -> F64Floor
        | 0x9duy -> F64Trunc
        | 0x9euy -> F64Nearest
        | 0x9fuy -> F64Sqrt
        | 0xa0uy -> F64Add
        | 0xa1uy -> F64Sub
        | 0xa2uy -> F64Mul
        | 0xa3uy -> F64Div
        | 0xa4uy -> F64Min
        | 0xa5uy -> F64Max
        | 0xa6uy -> F64Copysign
        | 0xa7uy -> I32WrapI64
        | 0xa8uy -> I32TruncF32S
        | 0xa9uy -> I32TruncF32U
        | 0xaauy -> I32TruncF64S
        | 0xabuy -> I32TruncF64U
        | 0xacuy -> I64ExtendI32S
        | 0xaduy -> I64ExtendI32U
        | 0xaeuy -> I64TruncF32S
        | 0xafuy -> I64TruncF32U
        | 0xb0uy -> I64TruncF64S
        | 0xb1uy -> I64TruncF64U
        | 0xb2uy -> F32ConvertI32S
        | 0xb3uy -> F32ConvertI32U
        | 0xb4uy -> F32ConvertI64S
        | 0xb5uy -> F32ConvertI64U
        | 0xb6uy -> F32DemoteF64
        | 0xb7uy -> F64ConvertI32S
        | 0xb8uy -> F64ConvertI32U
        | 0xb9uy -> F64ConvertI64S
        | 0xbauy -> F64ConvertI64U
        | 0xbbuy -> F64PromoteF32
        | 0xbcuy -> I32ReinterpretF32
        | 0xbduy -> I64ReinterpretF64
        | 0xbeuy -> F32ReinterpretI32
        | 0xbfuy -> F64ReinterpretI64
        | _      -> failwith "unknown opcode"

