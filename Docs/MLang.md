# Miku's OSEmu Language
Miku's OSEmu Language, 简称为MLang, 是一种仅用于本操作系统模拟器的类脚本语言.

MLang只有脚本解析器, 没有编译器和汇编器, MLang代码可以直接提交给本系统的模拟处理器, 经由内置的解析器解析后便可运行.

### 语法

#### 变量

MLang是弱类型语言, 

MLang仅支持四种变量类型: `int`, `double`, `string`.

#### 语句

##### 操作语句

- `<arg>=[value]` : 将值`value`赋值给`reg`.
- `<arg1>=<arg2>`: 将`arg2`的值赋值给`arg1`.
- `<arg>++`: 将`arg`的值加一.
- `<arg>--`: 将`arg`的值减一.

注意, 操作符和操作数之间不可有空格.

#### 系统指令语句
- `/time` 获取当前系统时间刻.(系统时间刻定义见系统文档)
- `/time <arg>` 获取当前系统时间刻, 并储存至`arg`.
- `/in <arg>`: 从标准输入读入一个整数、浮点数或字符, 并将其赋值给`arg`. 若输入的数据类型与`arg`的类型不匹配, 则会报错.
- `/out <arg>`: 将`arg`的值输出到标准输出.
- `/access <device_name> <int value>`: 启用名为`device_name`的设备, 使用时长为`value`个系统时间刻.
- `/exit` : 退出本程序

### 错误
由于本语言特性, MLang没有运行时错误, 只有解析错误.

当解释器遇到解析错误时, 会中止解析, 并通过系统的标准输出, 输出错误信息.

所有错误类型如下:
- `Unknowed System Command ERROR`
- `Unknowed Device ERROR`
- `Invalid Scripts ERROR`