using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace ParadoxForge.Scripts
{
    public class Memory
    {
        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(nint hObject);

        [DllImport("Kernel32.dll")]
        private static extern bool ReadProcessMemory(nint hProcess, nint lpBaseAddress, [Out] byte[] lpBuffer, int nSize, nint lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        private static extern nint CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, nint lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, nint hTemplateFile);

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(nint hProcess, nint lpBaseAddress, byte[] lpBuffer, int size, nint lpNumberOfBytesWritten);

        private Process _process;
        public Memory(string process)
        {
            _process = SetProcess(process);
        }
        public Process SetProcess(string name)
        {
            _process = Process.GetProcessesByName(name)[0];

            return _process;
        }
        public Process GetProcess()
        {
            return _process;
        }
        public nint GetModuleBase(string module)
        {
            try
            {
                if (module.Contains(".exe") && _process.MainModule != null)
                {
                    return _process.MainModule.BaseAddress;
                }

                foreach (ProcessModule mdl in _process.Modules)
                {
                    if (mdl.ModuleName == module)
                    {
                        return mdl.BaseAddress;
                    }
                }
            }
            catch { }

            return nint.Zero;
        }
        public nint ReadPointer(nint ptr)
        {
            byte[] array = new byte[8];
            ReadProcessMemory(_process.Handle, ptr, array, array.Length, nint.Zero);
            return (nint)BitConverter.ToInt64(array);
        }
        public nint ReadPointer(nint ptr, int offset)
        {
            byte[] array = new byte[8];
            ReadProcessMemory(_process.Handle, ptr + offset, array, array.Length, nint.Zero);
            return (nint)BitConverter.ToInt64(array);
        }
        public nint ReadPointer(long ptr, long offset)
        {
            byte[] array = new byte[8];
            ReadProcessMemory(_process.Handle, (nint)(ptr + offset), array, array.Length, nint.Zero);
            return (nint)BitConverter.ToInt64(array);
        }
        public nint ReadPointer(nint ptr, long offset)
        {
            return ReadPointer(ptr, offset);
        }
        public nint ReadPointer(nint ptr, int[] offsets)
        {
            nint intPtr = ptr;
            foreach (int offset in offsets)
            {
                intPtr = ReadPointer(intPtr, offset);
            }

            return intPtr;
        }
        public nint ReadPointer(nint ptr, long[] offsets)
        {
            nint intPtr = ptr;
            foreach (long offset in offsets)
            {
                intPtr = ReadPointer(intPtr, offset);
            }

            return intPtr;
        }
        public nint ReadPointer(nint ptr, int offset1, int offset2)
        {
            return ReadPointer(ptr, new int[2] { offset1, offset2 });
        }
        public nint ReadPointer(nint ptr, int offset1, int offset2, int offset3)
        {
            return ReadPointer(ptr, new int[3] { offset1, offset2, offset3 });
        }

        public nint ReadPointer(nint ptr, int offset1, int offset2, int offset3, int offset4)
        {
            return ReadPointer(ptr, new int[4] { offset1, offset2, offset3, offset4 });
        }

        public nint ReadPointer(nint ptr, int offset1, int offset2, int offset3, int offset4, int offset5)
        {
            return ReadPointer(ptr, new int[5] { offset1, offset2, offset3, offset4, offset5 });
        }

        public nint ReadPointer(nint ptr, int offset1, int offset2, int offset3, int offset4, int offset5, int offset6)
        {
            return ReadPointer(ptr, new int[6] { offset1, offset2, offset3, offset4, offset5, offset6 });
        }

        public nint ReadPointer(nint ptr, int offset1, int offset2, int offset3, int offset4, int offset5, int offset6, int offset7)
        {
            return ReadPointer(ptr, new int[7] { offset1, offset2, offset3, offset4, offset5, offset6, offset7 });
        }

        public nint ReadPointer(nint ptr, long offset1, long offset2)
        {
            return ReadPointer(ptr, new long[2] { offset1, offset2 });
        }

        public nint ReadPointer(nint ptr, long offset1, long offset2, long offset3)
        {
            return ReadPointer(ptr, new long[3] { offset1, offset2, offset3 });
        }

        public nint ReadPointer(nint ptr, long offset1, long offset2, long offset3, long offset4)
        {
            return ReadPointer(ptr, new long[4] { offset1, offset2, offset3, offset4 });
        }

        public nint ReadPointer(nint ptr, long offset1, long offset2, long offset3, long offset4, long offset5)
        {
            return ReadPointer(ptr, new long[5] { offset1, offset2, offset3, offset4, offset5 });
        }

        public nint ReadPointer(nint ptr, long offset1, long offset2, long offset3, long offset4, long offset5, long offset6)
        {
            return ReadPointer(ptr, new long[6] { offset1, offset2, offset3, offset4, offset5, offset6 });
        }

        public nint ReadPointer(nint ptr, long offset1, long offset2, long offset3, long offset4, long offset5, long offset6, long offset7)
        {
            return ReadPointer(ptr, new long[7] { offset1, offset2, offset3, offset4, offset5, offset6, offset7 });
        }

        public nint ReadPointer(nint ptr, nint offset1, int offset2)
        {
            nint ptr2 = ReadPointer((nint)(ptr + (long)offset1));
            return ReadPointer(ptr2, offset2);
        }

        public byte[] ReadBytes(nint ptr, int bytes)
        {
            byte[] array = new byte[bytes];
            ReadProcessMemory(_process.Handle, ptr, array, array.Length, nint.Zero);
            return array;
        }
        public byte[] ReadBytes(nint ptr, int offset, int bytes)
        {
            byte[] array = new byte[bytes];
            ReadProcessMemory(_process.Handle, ptr + offset, array, array.Length, nint.Zero);
            return array;
        }
        public int ReadInt(nint address)
        {
            return BitConverter.ToInt32(ReadBytes(address, 4));
        }
        public int ReadInt(nint address, int offset)
        {
            return BitConverter.ToInt32(ReadBytes(address + offset, 4));
        }
        public nint ReadLong(nint address)
        {
            return (nint)BitConverter.ToInt64(ReadBytes(address, 8));
        }
        public nint ReadLong(nint address, int offset)
        {
            return (nint)BitConverter.ToInt64(ReadBytes(address + offset, 8));
        }
        public float ReadFloat(nint address)
        {
            return BitConverter.ToSingle(ReadBytes(address, 4));
        }

        public float ReadFloat(nint address, int offset)
        {
            return BitConverter.ToSingle(ReadBytes(address + offset, 4));
        }

        public double ReadDouble(nint address)
        {
            return BitConverter.ToDouble(ReadBytes(address, 8));
        }

        public double ReadDouble(nint address, int offset)
        {
            return BitConverter.ToDouble(ReadBytes(address + offset, 4));
        }

        public Vector3 ReadVec(nint address)
        {
            byte[] value = ReadBytes(address, 12);
            Vector3 result = default;
            result.X = BitConverter.ToSingle(value, 0);
            result.Y = BitConverter.ToSingle(value, 4);
            result.Z = BitConverter.ToSingle(value, 8);
            return result;
        }

        public Vector3 ReadVec(nint address, int offset)
        {
            byte[] value = ReadBytes(address + offset, 12);
            Vector3 result = default;
            result.X = BitConverter.ToSingle(value, 0);
            result.Y = BitConverter.ToSingle(value, 4);
            result.Z = BitConverter.ToSingle(value, 8);
            return result;
        }

        public double[] ReadDoubleVec(nint address)
        {
            byte[] value = ReadBytes(address, 24);
            return new double[3]
            {
            BitConverter.ToDouble(value, 0),
            BitConverter.ToDouble(value, 8),
            BitConverter.ToDouble(value, 16)
            };
        }

        public double[] ReadDoubleVec(nint address, int offset)
        {
            byte[] value = ReadBytes(address + offset, 24);
            return new double[3]
            {
            BitConverter.ToDouble(value, 0),
            BitConverter.ToDouble(value, 8),
            BitConverter.ToDouble(value, 16)
            };
        }

        public short ReadShort(nint address)
        {
            return BitConverter.ToInt16(ReadBytes(address, 2));
        }

        public short ReadShort(nint address, int offset)
        {
            return BitConverter.ToInt16(ReadBytes(address + offset, 2));
        }

        public ushort ReadUShort(nint address)
        {
            return BitConverter.ToUInt16(ReadBytes(address, 2));
        }

        public ushort ReadUShort(nint address, int offset)
        {
            return BitConverter.ToUInt16(ReadBytes(address + offset, 2));
        }

        public uint ReadUInt(nint address)
        {
            return BitConverter.ToUInt32(ReadBytes(address, 4));
        }

        public uint ReadUInt(nint address, int offset)
        {
            return BitConverter.ToUInt32(ReadBytes(address + offset, 4));
        }

        public ulong ReadULong(nint address)
        {
            return BitConverter.ToUInt64(ReadBytes(address, 8));
        }

        public ulong ReadULong(nint address, int offset)
        {
            return BitConverter.ToUInt64(ReadBytes(address + offset, 8));
        }

        public bool ReadBool(nint address)
        {
            return BitConverter.ToBoolean(ReadBytes(address, 1));
        }

        public bool ReadBool(nint address, int offset)
        {
            return BitConverter.ToBoolean(ReadBytes(address + offset, 1));
        }

        public string ReadString(nint address, int length)
        {
            return Encoding.UTF8.GetString(ReadBytes(address, length));
        }

        public string ReadString(nint address, int offset, int length)
        {
            return Encoding.UTF8.GetString(ReadBytes(address + offset, length));
        }

        public char ReadChar(nint address)
        {
            return BitConverter.ToChar(ReadBytes(address, 2));
        }

        public char ReadChar(nint address, int offset)
        {
            return BitConverter.ToChar(ReadBytes(address + offset, 2));
        }

        public float[] ReadMatrix(nint address)
        {
            byte[] array = ReadBytes(address, 64);
            float[] array2 = new float[array.Length];
            array2[0] = BitConverter.ToSingle(array, 0);
            array2[1] = BitConverter.ToSingle(array, 4);
            array2[2] = BitConverter.ToSingle(array, 8);
            array2[3] = BitConverter.ToSingle(array, 12);
            array2[4] = BitConverter.ToSingle(array, 16);
            array2[5] = BitConverter.ToSingle(array, 20);
            array2[6] = BitConverter.ToSingle(array, 24);
            array2[7] = BitConverter.ToSingle(array, 28);
            array2[8] = BitConverter.ToSingle(array, 32);
            array2[9] = BitConverter.ToSingle(array, 36);
            array2[10] = BitConverter.ToSingle(array, 40);
            array2[11] = BitConverter.ToSingle(array, 44);
            array2[12] = BitConverter.ToSingle(array, 48);
            array2[13] = BitConverter.ToSingle(array, 52);
            array2[14] = BitConverter.ToSingle(array, 56);
            array2[15] = BitConverter.ToSingle(array, 60);
            return array2;
        }

        public bool WriteBytes(nint address, byte[] newbytes)
        {
            return WriteProcessMemory(_process.Handle, address, newbytes, newbytes.Length, nint.Zero);
        }

        public bool WriteBytes(nint address, int offset, byte[] newbytes)
        {
            return WriteProcessMemory(_process.Handle, address + offset, newbytes, newbytes.Length, nint.Zero);
        }

        public bool WriteBytes(nint address, string newbytes)
        {
            byte[] array = (from b in newbytes.Split(' ')
                            select Convert.ToByte(b, 16)).ToArray();
            return WriteProcessMemory(_process.Handle, address, array, array.Length, nint.Zero);
        }

        public bool WriteBytes(nint address, int offset, string newbytes)
        {
            byte[] array = (from b in newbytes.Split(' ')
                            select Convert.ToByte(b, 16)).ToArray();
            return WriteProcessMemory(_process.Handle, address + offset, array, array.Length, nint.Zero);
        }

        public bool WriteDoubleVec(nint address, double[] value)
        {
            byte[] array = new byte[24];
            byte[] bytes = BitConverter.GetBytes(value[0]);
            byte[] bytes2 = BitConverter.GetBytes(value[1]);
            byte[] bytes3 = BitConverter.GetBytes(value[2]);
            bytes.CopyTo(array, 0);
            bytes2.CopyTo(array, 8);
            bytes3.CopyTo(array, 16);
            return WriteBytes(address, array);
        }

        public bool WriteDoubleVec(nint address, int offset, double[] value)
        {
            byte[] array = new byte[24];
            byte[] bytes = BitConverter.GetBytes(value[0]);
            byte[] bytes2 = BitConverter.GetBytes(value[1]);
            byte[] bytes3 = BitConverter.GetBytes(value[2]);
            bytes.CopyTo(array, 0);
            bytes2.CopyTo(array, 8);
            bytes3.CopyTo(array, 16);
            return WriteBytes(address + offset, array);
        }

        public bool WriteInt(nint address, int value)
        {
            return WriteBytes(address, BitConverter.GetBytes(value));
        }

        public bool WriteInt(nint address, int offset, int value)
        {
            return WriteBytes(address + offset, BitConverter.GetBytes(value));
        }

        public bool WriteShort(nint address, short value)
        {
            return WriteBytes(address, BitConverter.GetBytes(value));
        }

        public bool WriteShort(nint address, int offset, short value)
        {
            return WriteBytes(address + offset, BitConverter.GetBytes(value));
        }

        public bool WriteUShort(nint address, ushort value)
        {
            return WriteBytes(address, BitConverter.GetBytes(value));
        }

        public bool WriteUShort(nint address, int offset, ushort value)
        {
            return WriteBytes(address + offset, BitConverter.GetBytes(value));
        }

        public bool WriteUInt(nint address, uint value)
        {
            return WriteBytes(address, BitConverter.GetBytes(value));
        }

        public bool WriteUInt(nint address, int offset, uint value)
        {
            return WriteBytes(address + offset, BitConverter.GetBytes(value));
        }

        public bool WriteLong(nint address, long value)
        {
            return WriteBytes(address, BitConverter.GetBytes(value));
        }

        public bool WriteLong(nint address, int offset, long value)
        {
            return WriteBytes(address + offset, BitConverter.GetBytes(value));
        }

        public bool WriteULong(nint address, ulong value)
        {
            return WriteBytes(address, BitConverter.GetBytes(value));
        }

        public bool WriteULong(nint address, int offset, ulong value)
        {
            return WriteBytes(address + offset, BitConverter.GetBytes(value));
        }

        public bool WriteFloat(nint address, float value)
        {
            return WriteBytes(address, BitConverter.GetBytes(value));
        }

        public bool WriteFloat(nint address, int offset, float value)
        {
            return WriteBytes(address + offset, BitConverter.GetBytes(value));
        }

        public bool WriteDouble(nint address, double value)
        {
            return WriteBytes(address, BitConverter.GetBytes(value));
        }

        public bool WriteDouble(nint address, int offset, double value)
        {
            return WriteBytes(address + offset, BitConverter.GetBytes(value));
        }

        public bool WriteBool(nint address, bool value)
        {
            return WriteBytes(address, BitConverter.GetBytes(value));
        }

        public bool WriteBool(nint address, int offset, bool value)
        {
            return WriteBytes(address + offset, BitConverter.GetBytes(value));
        }

        public bool WriteString(nint address, string value)
        {
            return WriteBytes(address, Encoding.UTF8.GetBytes(value));
        }

        public bool WriteVec(nint address, Vector3 value)
        {
            byte[] array = new byte[12];
            byte[] bytes = BitConverter.GetBytes(value.X);
            byte[] bytes2 = BitConverter.GetBytes(value.Y);
            byte[] bytes3 = BitConverter.GetBytes(value.Z);
            bytes.CopyTo(array, 0);
            bytes2.CopyTo(array, 4);
            bytes3.CopyTo(array, 8);
            return WriteBytes(address, array);
        }

        public bool WriteVec(nint address, int offset, Vector3 value)
        {
            byte[] array = new byte[12];
            byte[] bytes = BitConverter.GetBytes(value.X);
            byte[] bytes2 = BitConverter.GetBytes(value.Y);
            byte[] bytes3 = BitConverter.GetBytes(value.Z);
            bytes.CopyTo(array, 0);
            bytes2.CopyTo(array, 4);
            bytes3.CopyTo(array, 8);
            return WriteBytes(address + offset, array);
        }

        public bool Nop(nint address, int length)
        {
            byte[] array = new byte[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = 144;
            }

            return WriteBytes(address, array);
        }

        public bool Nop(nint address, int offset, int length)
        {
            byte[] array = new byte[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = 144;
            }

            return WriteBytes(address + offset, array);
        }
        public nint ScanForBytes32(string moduleName, string needle)
        {
            string moduleName2 = moduleName;
            ProcessModule processModule = _process.Modules.OfType<ProcessModule>().FirstOrDefault((x) => x.ModuleName == moduleName2);

            byte[] needle2 = (from b in needle.Split(' ')
                              select Convert.ToByte(b, 16)).ToArray();

            byte[] array;
            using (FileStream fileStream = new FileStream(processModule.FileName, FileMode.Open, FileAccess.Read))
            {
                array = new byte[fileStream.Length];
                fileStream.Read(array, 0, (int)fileStream.Length);
            }

            return (nint)ScanForBytes32(array, needle2);
        }
        public long ScanForBytes32(byte[] haystack, byte[] needle)
        {
            for (int i = 0; i < haystack.Length - needle.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < needle.Length; j++)
                {
                    if (needle[j] != byte.MaxValue && haystack[i + j] != needle[j])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    return i;
                }
            }

            return -1L;
        }
    }
}
