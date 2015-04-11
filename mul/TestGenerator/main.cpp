#include <iostream>
#include <string>
#include <cstdlib>
#include <cstdio>
#include <sstream>
#include <ostream>
#include <fstream>

enum floatKind
{
  FK_ZERO = 0, FK_NEG_ZERO, FK_POS_NAN, FK_NEG_NAN, FK_POS_INF, FK_NEG_INF,
  FK_LAST
};

unsigned long long floatKind2int64(floatKind fk)
{
    unsigned long long val64[FK_LAST] = {0, 0x8000000000000000ull, 0x7ff8000000000000ull, 0xfff8000000000000ull, 0x7ff0000000000000ull, 0xfff0000000000000ull};
    return val64[fk];
}

std::string floatKind2string(floatKind fk)
{
    std::string strVal[FK_LAST] = {"0", "-0", "nan", "nan", "+inf", "-inf"};
    if(fk < FK_LAST)
        return strVal[fk];
    else
        return "unknown";
}

unsigned long float2long(float f)
{
  return * static_cast<unsigned long*>((void*)&f);
}

float long2float(unsigned long l)
{
  if(!(l & 0x7f800000ul))
  {
      l  &= 0x80000000ul;
  }
  return * static_cast<float*>((void*)&l);
}

void subnormalToZero(unsigned long long &x)
{
  //check if subnormal
  if(!(x & 0x7ff0000000000000ull))
  {
      x &= 0x8000000000000000ull;
  }
}

double longlong2double(unsigned long long ll)
{
//  subnormalToZero(ll);
  return * static_cast<double*>((void*)&ll);
}

unsigned long long double2longlong(double d)
{
  unsigned long long ll = * static_cast<unsigned long long*>((void*)&d);
  subnormalToZero(ll);
  return ll;
}

void subnormalToZero(double &x)
{
	x = longlong2double(double2longlong(x));
}

std::string double2string(double x)
{
    for(int fk_i = FK_ZERO; fk_i < FK_LAST; fk_i++)
    {
        floatKind fk_x = static_cast<floatKind>(fk_i);

        unsigned long long fk_int64 = floatKind2int64(fk_x);
        unsigned long long x_int64= double2longlong(x);

        if(fk_int64 == x_int64)
        {
            return floatKind2string(fk_x);
        }
    }
    std::stringstream s;
    s << x;
    return s.str();
}

unsigned char randomByte()
{
    return rand() & 0xFF;
}

unsigned long long randomInt64()
{
    unsigned long long result = 0;
    unsigned long long shifted_byte;
    for(int i = 0; i < 64; i += 8)
    {
        shifted_byte = (unsigned long long)(randomByte()) << i;
        result |= shifted_byte;
    }
    return result;
}

void printLine(std::ostream &out, unsigned long long ll_x, unsigned long long ll_y)
{
    double d_x = longlong2double(ll_x);
    double d_y = longlong2double(ll_y);
	double d_x_corr, d_y_corr; 
    out.fill('0');
    out.width(16);
    out << std::hex << ll_x << " ";
    out.width(16);
    out << ll_y << " ";
    out.width(16);
	// значения после удаления денормализованных чисел
	d_x_corr = d_x;
	d_y_corr = d_y;
	subnormalToZero(d_x_corr);
	subnormalToZero(d_y_corr);
    out <<  double2longlong(d_x_corr * d_y_corr);
    out << " //" << double2string(d_x) << " * " << double2string(d_y) << " = " << double2string(d_x_corr * d_y_corr) << std::endl;
}

int main()
{
    std::ofstream testfile;
    testfile.open ("test_file.txt");
    for(int fk_i = FK_ZERO; fk_i < FK_LAST; fk_i++)
    {
        for(int fk_j = FK_ZERO; fk_j < FK_LAST; fk_j++)
        {
            floatKind fk_x = static_cast<floatKind>(fk_i);
            floatKind fk_y = static_cast<floatKind>(fk_j);
            unsigned long long ll_x = floatKind2int64(fk_x);
            unsigned long long ll_y = floatKind2int64(fk_y);
            printLine(testfile, ll_x, ll_y);
        }
    }
    //-----------
    for(int i = 0; i <= 10000; i++)
    {
        printLine(testfile, randomInt64(), randomInt64());
    }
    testfile.close();
    return 0;
}
