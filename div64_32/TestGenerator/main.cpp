#include <iostream>
#include <string>
#include <cstdlib>
#include <cstdio>
#include <sstream>
#include <ostream>
#include <fstream>

enum class FloatKind
{
  FK_GENERAL = -1, FK_ZERO = 0, FK_NEG_ZERO, FK_POS_NAN, FK_NEG_NAN, FK_POS_INF, FK_NEG_INF,
  FK_LAST
};

enum class OperandsType
{
  OT_F32 = 0, OT_F64, //OT_F80, OT_BCD,
  OT_LAST
};

unsigned long floatKind2int64(FloatKind fk)
{
    unsigned long val64[(int)FloatKind::FK_LAST] = {0, 0x8000000000000000ull, 0x7ff0000000000001ull, 0xfff0000000000001ull, 0x7ff0000000000000ull, 0xfff0000000000000ull};
    return val64[(int)fk];
}

unsigned int floatKind2int32(FloatKind fk)
{
    unsigned int val32[(int)FloatKind::FK_LAST] = {0, 0x80000000ul, 0x7f800001ul, 0xff800001ul, 0x7f800000ul, 0xff800000ul};
    return val32[(int)fk];
}

std::string floatKind2string(FloatKind fk)
{
    std::string strVal[(int)FloatKind::FK_LAST] = {"0.0", "-0.0", "nan", "-nan", "+inf", "-inf"};
    if(fk < FloatKind::FK_LAST)
        return strVal[(int)fk];
    else
        return "unknown";
}

std::string operandsType2string(OperandsType ot)
{
	std::string strVal[(int)OperandsType::OT_LAST] = {"f32", "f64", /* "f80", "bcd" */};
	if(ot < OperandsType::OT_LAST)
        return strVal[(int)ot];
    else
        return "unknown";
}

unsigned int float2int(float f)
{
  return * static_cast<unsigned int*>((void*)&f);
}

float int2float(unsigned int l)
{
	return * static_cast<float*>((void*)&l);
}

double long2double(unsigned long ul)
{
  return * static_cast<double*>((void*)&ul);
}

unsigned long double2long(double d)
{
  return * static_cast<unsigned long*>((void*)&d);
}

unsigned char randomByte()
{
    return rand();
}

unsigned __int128 randomInt(OperandsType ot)
{
    unsigned long result = 0;
    unsigned long shifted_byte;
	int op_size;
	if(ot == OperandsType::OT_F32)
	{
		op_size = 32;
	} 
	else if(ot == OperandsType::OT_F64)
	{
		op_size = 64;
	}
	else op_size = -1; // other types not supported yet
    for(int i = 0; i < op_size; i += 8)
    {
        shifted_byte = (unsigned long)(randomByte()) << i;
        result |= shifted_byte;
    }
    return result;
}

OperandsType randomOperandsType()
{
	return static_cast<OperandsType>(rand() % (int)OperandsType::OT_LAST);
}

std::string f32ToString(unsigned int x)
{
	std::stringstream s;
	if((x & 0xff800000ul) == 0x7f800000ul && (x & 0x007ffffful)) return floatKind2string(FloatKind::FK_POS_NAN);
	if((x & 0xff800000ul) == 0xff800000ul && (x & 0x007ffffful)) return floatKind2string(FloatKind::FK_NEG_NAN);
	if((x & 0xff800000ul) == 0x7f800000ul && !(x & 0x007ffffful)) return floatKind2string(FloatKind::FK_POS_INF);	
	if((x & 0xff800000ul) == 0xff800000ul && !(x & 0x007ffffful)) return floatKind2string(FloatKind::FK_NEG_INF);
	if((x & 0xff800000ul) == 0x00000000ul) return floatKind2string(FloatKind::FK_ZERO);
	if((x & 0xff800000ul) == 0x80000000ul) return floatKind2string(FloatKind::FK_NEG_ZERO);
	s << int2float(x);
	return s.str();
}

std::string f64ToString(unsigned long x)
{
	std::stringstream s;
	if((x & 0xfff0000000000000ull) == 0x7ff0000000000000ull && (x & 0x000fffffffffffffull)) return floatKind2string(FloatKind::FK_POS_NAN);
	if((x & 0xfff0000000000000ull) == 0xfff0000000000000ull && (x & 0x000fffffffffffffull)) return floatKind2string(FloatKind::FK_NEG_NAN);
	if((x & 0xfff0000000000000ull) == 0x7ff0000000000000ull && !(x & 0x000fffffffffffffull)) return floatKind2string(FloatKind::FK_POS_INF);
	if((x & 0xfff0000000000000ull) == 0xfff0000000000000ull && !(x & 0x000fffffffffffffull)) return floatKind2string(FloatKind::FK_NEG_INF);
	if((x & 0xfff0000000000000ull) == 0x0000000000000000ull) return floatKind2string(FloatKind::FK_ZERO);
	if((x & 0xfff0000000000000ull) == 0x8000000000000000ull) return floatKind2string(FloatKind::FK_NEG_ZERO);
	s << long2double(x);
	return s.str();
}

std::string f32PrintLine(unsigned int lhs, unsigned int rhs)
{
	std::stringstream out;
	float x = int2float(lhs);
    float y = int2float(rhs);
	unsigned int result = float2int(x / y);
	out << "F32 ";
    out.fill('0');
    out.width(8);
    out << std::hex << lhs << " ";
    out.width(8);
    out << rhs << " ";
    out.width(8);
    out << result;
    out << " //" << f32ToString(lhs) << " / " << f32ToString(rhs) << " = " << f32ToString(result) << std::endl;
	return out.str();
}

std::string f64PrintLine(unsigned long lhs, unsigned long rhs)
{
	std::stringstream out;
	double x = long2double(lhs);
    double y = long2double(rhs);
	unsigned long result = double2long((double) ((double)x / (double)y));
	out << "F64 ";
    out.fill('0');
    out.width(16);
    out << std::hex << lhs << " ";
    out.width(16);
    out << rhs << " ";
    out.width(16);
    out << result;
    out << " //" << f64ToString(lhs) << " / " << f64ToString(rhs) << " = " << f64ToString(result) << std::endl;
	return out.str();
}

std::string getLine(OperandsType ot, unsigned __int128 lhs, unsigned __int128 rhs)
{
	switch (ot)
	{
		case OperandsType::OT_F32: return f32PrintLine((unsigned int)lhs, (unsigned int)rhs);
		case OperandsType::OT_F64: return f64PrintLine((unsigned long)lhs, (unsigned long)rhs);
		default: return nullptr; // unknown operand type
	}
}

int main()
{
    std::ofstream testfile;
    testfile.open ("test_file.txt");
    for(int fk_i = (int)FloatKind::FK_ZERO; fk_i < (int)FloatKind::FK_LAST; fk_i++)
    {
        for(int fk_j = (int)FloatKind::FK_ZERO; fk_j < (int)FloatKind::FK_LAST; fk_j++)
        {
            FloatKind fk_x = static_cast<FloatKind>(fk_i);
            FloatKind fk_y = static_cast<FloatKind>(fk_j);
            unsigned long l_x = floatKind2int32(fk_x);
            unsigned long l_y = floatKind2int32(fk_y);
            std::string s = getLine(OperandsType::OT_F32, l_x, l_y);
			testfile << s;
        }
    }
	for(int fk_i = (int)FloatKind::FK_ZERO; fk_i < (int)FloatKind::FK_LAST; fk_i++)
    {
        for(int fk_j = (int)FloatKind::FK_ZERO; fk_j < (int)FloatKind::FK_LAST; fk_j++)
        {
            FloatKind fk_x = static_cast<FloatKind>(fk_i);
            FloatKind fk_y = static_cast<FloatKind>(fk_j);
            unsigned long long ll_x = floatKind2int64(fk_x);
            unsigned long long ll_y = floatKind2int64(fk_y);
            std::string s = getLine(OperandsType::OT_F64, ll_x, ll_y);
			testfile << s;
        }
    }
    //-----------
    for(int i = 0; i <= 10000; i++)
    {
		OperandsType ot = randomOperandsType();
		std::string s = getLine(ot, randomInt(ot), randomInt(ot));
		testfile << s;
    }
    testfile.close();
    return 0;
}
