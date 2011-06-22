###############################################################################
# Makefile for the project MotorPendelUhr_328P
###############################################################################

## General Flags
PROJECT = MotorPendelUhr_328P
MCU = atmega328p
TARGET = MotorPendelUhr_328P.elf
CC = avr-gcc

## Options common to compile, link and assembly rules
COMMON = -mmcu=$(MCU)

## Compile options common for all C compilation units.
CFLAGS = $(COMMON)
CFLAGS += -Wall -gdwarf-2 -Os -std=gnu99 -funsigned-char -funsigned-bitfields -fpack-struct -fshort-enums
CFLAGS += -MD -MP -MT $(*F).o -MF dep/$(@F).d 

## Assembly specific flags
ASMFLAGS = $(COMMON)
ASMFLAGS += $(CFLAGS)
ASMFLAGS += -x assembler-with-cpp -Wa,-gdwarf2

## Linker flags
LDFLAGS = $(COMMON)
LDFLAGS +=  -Wl,-Map=MotorPendelUhr_328P.map


## Intel Hex file production flags
HEX_FLASH_FLAGS = -R .eeprom -R .fuse -R .lock -R .signature

HEX_EEPROM_FLAGS = -j .eeprom
HEX_EEPROM_FLAGS += --set-section-flags=.eeprom="alloc,load"
HEX_EEPROM_FLAGS += --change-section-lma .eeprom=0 --no-change-warnings


## Objects that must be built in order to link
OBJECTS = MotorPendelUhr_328P.o dcf77.o ledText.o uart.o 

## Objects explicitly added by the user
LINKONLYOBJECTS = 

## Build
all: $(TARGET) MotorPendelUhr_328P.hex MotorPendelUhr_328P.eep MotorPendelUhr_328P.lss size

## Compile
MotorPendelUhr_328P.o: ../MotorPendelUhr_328P.c
	$(CC) $(INCLUDES) $(CFLAGS) -c  $<

dcf77.o: ../dcf77.c
	$(CC) $(INCLUDES) $(CFLAGS) -c  $<

ledText.o: ../ledText.c
	$(CC) $(INCLUDES) $(CFLAGS) -c  $<

uart.o: ../uart.c
	$(CC) $(INCLUDES) $(CFLAGS) -c  $<

##Link
$(TARGET): $(OBJECTS)
	 $(CC) $(LDFLAGS) $(OBJECTS) $(LINKONLYOBJECTS) $(LIBDIRS) $(LIBS) -o $(TARGET)

%.hex: $(TARGET)
	avr-objcopy -O ihex $(HEX_FLASH_FLAGS)  $< $@

%.eep: $(TARGET)
	-avr-objcopy $(HEX_EEPROM_FLAGS) -O ihex $< $@ || exit 0

%.lss: $(TARGET)
	avr-objdump -h -S $< > $@

size: ${TARGET}
	@echo
	@avr-size -C --mcu=${MCU} ${TARGET}

## Clean target
.PHONY: clean
clean:
	-rm -rf $(OBJECTS) MotorPendelUhr_328P.elf dep/* MotorPendelUhr_328P.hex MotorPendelUhr_328P.eep MotorPendelUhr_328P.lss MotorPendelUhr_328P.map


## Other dependencies
-include $(shell mkdir dep 2>/dev/null) $(wildcard dep/*)

