Module REGISTERS
 ' //---------------------------------------------------------
 ' // Test Cases
 ' //---------------------------------------------------------
 ' // ############################################################################
 ' // # Copyright (c) 2015  Maxim Integrated Products                            #
 ' // # All Rights Reserved.                                                     #
 ' // # THIS MATERIAL IS CONSIDERED CONFIDENTIAL AND PROPRIETARY BY              #
 ' // # Maxim Integrated Products.                                               #
 ' // # UNAUTHORIZED ACCESS OR USE IS PROHIBITED.                                #
 ' // ############################################################################
 ' //   File       :  foo.svh
 ' //   Author     :  Generated automatically by RegisterMap
 ' //   Description:  SST Register defines
 ' // ############################################################################
Public Const reg_INTERRUPT_RAW_1 As Long=1
Public Const reg_INTERRUPT_RAW_2 As Long=2
Public Const reg_INTERRUPT_RAW_3 As Long=3
Public Const reg_INTERRUPT_STATE_1 As Long=4
Public Const reg_INTERRUPT_STATE_2 As Long=5
Public Const reg_INTERRUPT_STATE_3 As Long=6
Public Const reg_INTERRUPT_FLAG_1 As Long=7
Public Const reg_INTERRUPT_FLAG_2 As Long=8
Public Const reg_INTERRUPT_FLAG_3 As Long=9
Public Const reg_INTERRUPT_ENABLE_1 As Long=10
Public Const reg_INTERRUPT_ENABLE_2 As Long=11
Public Const reg_INTERRUPT_ENABLE_3 As Long=12
Public Const reg_INTERRUPT_FLAG_CLEAR_1 As Long=13
Public Const reg_INTERRUPT_FLAG_CLEAR_2 As Long=14
Public Const reg_INTERRUPT_FLAG_CLEAR_3 As Long=15
Public Const reg_IRQ_CONTROL As Long=16
Public Const reg_CLOCK_MONITOR_ENABLE As Long=17
Public Const reg_WATCHDOG_CONTROL As Long=18
Public Const reg_WATCHDOG_SW_RESET As Long=19
Public Const reg_MEAS_ADC_THERMAL_WARNING_THRESHHOLD As Long=20
Public Const reg_MEAS_ADC_THERMAL_SHUTDOWN_THRESHHOLD As Long=21
Public Const reg_MEAS_ADC_THERMAL_HYSTERESIS As Long=22
Public Const reg_PIN_CONFIG As Long=23
Public Const reg_PCM_RX_ENABLES_A As Long=24
Public Const reg_PCM_RX_ENABLES_B As Long=25
Public Const reg_PCM_TX_ENABLES_A As Long=26
Public Const reg_PCM_TX_ENABLES_B As Long=27
Public Const reg_PCM_TX_HIZ_CONTROL_A As Long=28
Public Const reg_PCM_TX_HIZ_CONTROL_B As Long=29
Public Const reg_PCM_TX_CHANNEL_SOURCES_A As Long=30
Public Const reg_PCM_TX_CHANNEL_SOURCES_B As Long=31
Public Const reg_PCM_MODE_CONFIG As Long=32
Public Const reg_PCM_MASTER_MODE As Long=33
Public Const reg_PCM_CLOCK_SETUP As Long=34
Public Const reg_PCM_SAMPLE_RATE_SETUP_1 As Long=35
Public Const reg_PCM_SAMPLE_RATE_SETUP_2 As Long=36
Public Const reg_PCM_TO_SPEAKER_MONOMIX_A As Long=37
Public Const reg_PCM_TO_SPEAKER_MONOMIX_B As Long=38
Public Const reg_ICC_RX_ENABLES_A As Long=39
Public Const reg_ICC_RX_ENABLES_B As Long=40
Public Const reg_ICC_TX_ENABLES_A As Long=43
Public Const reg_ICC_TX_ENABLES_B As Long=44
Public Const reg_ICC_DATA_ORDER_SELECT As Long=45
Public Const reg_ICC_HIZ_MANUAL_MODE As Long=46
Public Const reg_ICC_TX_HIZ_ENABLES_A As Long=47
Public Const reg_ICC_TX_HIZ_ENABLES_B As Long=48
Public Const reg_ICC_LINK_ENABLES As Long=49
Public Const reg_PDM_TX_ENABLES As Long=50
Public Const reg_PDM_TX_HIZ_CONTROL As Long=51
Public Const reg_PDM_TX_CONTROL As Long=52
Public Const reg_PDM_RX_ENABLE As Long=53
Public Const reg_AMP_VOLUME_CONTROL As Long=54
Public Const reg_AMP_DSP_CONFIG As Long=55
Public Const reg_TONE_GENERATOR_AND_DC_CONFIG As Long=56
Public Const reg_DRE_CONTROL As Long=57
Public Const reg_AMP_ENABLES As Long=58
Public Const reg_SPEAKER_SOURCE_SELECT As Long=59
Public Const reg_SPEAKER_GAIN As Long=60
Public Const reg_SSM_CONFIGURATION As Long=61
Public Const reg_MEASUREMENT_ENABLES As Long=62
Public Const reg_MEASUREMENT_DSP_CONFIG As Long=63
Public Const reg_BOOST_CONTROL_0 As Long=64
Public Const reg_BOOST_CONTROL_3 As Long=65
Public Const reg_BOOST_CONTROL_1 As Long=66
Public Const reg_MEAS_ADC_CONFIG As Long=67
Public Const reg_MEAS_ADC_BASE_DIVIDE_MSBYTE As Long=68
Public Const reg_MEAS_ADC_BASE_DIVIDE_LSBYTE As Long=69
Public Const reg_MEAS_ADC_CHAN_0_DIVIDE As Long=70
Public Const reg_MEAS_ADC_CHAN_1_DIVIDE As Long=71
Public Const reg_MEAS_ADC_CHAN_2_DIVIDE As Long=72
Public Const reg_MEAS_ADC_CHAN_0_FILT_CONFIG As Long=73
Public Const reg_MEAS_ADC_CHAN_1_FILT_CONFIG As Long=74
Public Const reg_MEAS_ADC_CHAN_2_FILT_CONFIG As Long=75
Public Const reg_MEAS_ADC_CHAN_0_READBACK As Long=76
Public Const reg_MEAS_ADC_CHAN_1_READBACK As Long=77
Public Const reg_MEAS_ADC_CHAN_2_READBACK As Long=78
Public Const reg_SQUELCH As Long=80
Public Const reg_BROWNOUT_STATUS As Long=81
Public Const reg_BROWNOUT_ENABLES As Long=82
Public Const reg_BROWNOUT_LEVEL_INFINITE_HOLD As Long=83
Public Const reg_BROWNOUT_LEVEL_INFINITE_HOLD_CLEAR As Long=84
Public Const reg_BROWNOUT_LEVEL_HOLD As Long=85
Public Const reg_BROWNOUT__LEVEL_1_THRESHOLD As Long=86
Public Const reg_BROWNOUT__LEVEL_2_THRESHOLD As Long=87
Public Const reg_BROWNOUT__LEVEL_3_THRESHOLD As Long=88
Public Const reg_BROWNOUT__LEVEL_4_THRESHOLD As Long=89
Public Const reg_BROWNOUT__LEVEL_5_THRESHOLD As Long=90
Public Const reg_BROWNOUT__LEVEL_6_THRESHOLD As Long=91
Public Const reg_BROWNOUT__LEVEL_7_THRESHOLD As Long=92
Public Const reg_BROWNOUT__LEVEL_8_THRESHOLD As Long=93
Public Const reg_BROWNOUT_THRESHOLD_HYSTERYSIS As Long=94
Public Const reg_BROWNOUT_AMP_LIMITER_ATTACK_RELEASE As Long=95
Public Const reg_BROWNOUT_AMP_GAIN_ATTACK_RELEASE As Long=96
Public Const reg_BROWNOUT_AMP1_CLIP_MODE As Long=97
Public Const reg_BROWNOUT__LEVEL_1_CURRENT_LIMIT As Long=98
Public Const reg_BROWNOUT__LEVEL_1_AMP_1_CONTROL_1 As Long=99
Public Const reg_BROWNOUT__LEVEL_1_AMP_1_CONTROL_2 As Long=100
Public Const reg_BROWNOUT__LEVEL_1_AMP_1_CONTROL_3 As Long=101
Public Const reg_BROWNOUT__LEVEL_2_CURRENT_LIMIT As Long=102
Public Const reg_BROWNOUT__LEVEL_2_AMP_1_CONTROL_1 As Long=103
Public Const reg_BROWNOUT__LEVEL_2_AMP_1_CONTROL_2 As Long=104
Public Const reg_BROWNOUT__LEVEL_2_AMP_1_CONTROL_3 As Long=105
Public Const reg_BROWNOUT__LEVEL_3_CURRENT_LIMIT As Long=106
Public Const reg_BROWNOUT__LEVEL_3_AMP_1_CONTROL_1 As Long=107
Public Const reg_BROWNOUT__LEVEL_3_AMP_1_CONTROL_2 As Long=108
Public Const reg_BROWNOUT__LEVEL_3_AMP_1_CONTROL_3 As Long=109
Public Const reg_BROWNOUT__LEVEL_4_CURRENT_LIMIT As Long=110
Public Const reg_BROWNOUT__LEVEL_4_AMP_1_CONTROL_1 As Long=111
Public Const reg_BROWNOUT__LEVEL_4_AMP_1_CONTROL_2 As Long=112
Public Const reg_BROWNOUT__LEVEL_4_AMP_1_CONTROL_3 As Long=113
Public Const reg_BROWNOUT__LEVEL_5_CURRENT_LIMIT As Long=114
Public Const reg_BROWNOUT__LEVEL_5_AMP_1_CONTROL_1 As Long=115
Public Const reg_BROWNOUT__LEVEL_5_AMP_1_CONTROL_2 As Long=116
Public Const reg_BROWNOUT__LEVEL_5_AMP_1_CONTROL_3 As Long=117
Public Const reg_BROWNOUT__LEVEL_6_CURRENT_LIMIT As Long=118
Public Const reg_BROWNOUT__LEVEL_6_AMP_1_CONTROL_1 As Long=119
Public Const reg_BROWNOUT__LEVEL_6_AMP_1_CONTROL_2 As Long=120
Public Const reg_BROWNOUT__LEVEL_6_AMP_1_CONTROL_3 As Long=121
Public Const reg_BROWNOUT__LEVEL_7_CURRENT_LIMIT As Long=122
Public Const reg_BROWNOUT__LEVEL_7_AMP_1_CONTROL_1 As Long=123
Public Const reg_BROWNOUT__LEVEL_7_AMP_1_CONTROL_2 As Long=124
Public Const reg_BROWNOUT__LEVEL_7_AMP_1_CONTROL_3 As Long=125
Public Const reg_BROWNOUT__LEVEL_8_CURRENT_LIMIT As Long=126
Public Const reg_BROWNOUT__LEVEL_8_AMP_1_CONTROL_1 As Long=127
Public Const reg_BROWNOUT__LEVEL_8_AMP_1_CONTROL_2 As Long=128
Public Const reg_BROWNOUT__LEVEL_8_AMP_1_CONTROL_3 As Long=129
Public Const reg_ENV_TRACKER_VOUT_HEADROOM As Long=130
Public Const reg_ENV_TRACKER_BOOST_VOUT_DELAY As Long=131
Public Const reg_ENV_TRACKER_RELEASE_RATE As Long=132
Public Const reg_ENV_TRACKER_HOLD_RATE As Long=133
Public Const reg_ENV_TRACKER_CONTROL As Long=134
Public Const reg_ENV_TRACKER__BOOST_VOUT_READBACK As Long=135
Public Const reg_ADVANCED_SETTINGS As Long=137
Public Const reg_MEAS_ADC_CHAN_0__RAW_L__READBACK As Long=139
Public Const reg_MEAS_ADC_CHAN_0__RAW_H__READBACK As Long=140
Public Const reg_MEAS_ADC_CHAN_1__RAW_L__READBACK As Long=141
Public Const reg_MEAS_ADC_CHAN_1__RAW_H__READBACK As Long=142
Public Const reg_MEAS_ADC_CHAN_2__RAW_L__READBACK As Long=143
Public Const reg_MEAS_ADC_CHAN_2__RAW_H__READBACK As Long=144
Public Const reg_MEAS_ADC_TEST_MAN_MODE_TRIGGER As Long=145
Public Const reg_MEAS_ADC_TEST_MODE_CONFIG As Long=146
Public Const reg_MEAS_ADC_TEST_MODE_DATA As Long=147
Public Const reg_MEAS_ADC_TEST_VPTAT As Long=148
Public Const reg_TEST_IVADC_CORRECTION_ENABLES As Long=149
Public Const reg_IVADC_TEST As Long=150
Public Const reg_IVFE_TEST_0 As Long=151
Public Const reg_TEST_IVFE_TEST_MODE_MSB As Long=152
Public Const reg_TEST_IVFE_TEST_MODE_LSB As Long=153
Public Const reg_TEST_IV_ENABLE_OVERRIDE As Long=154
Public Const reg_DRE_TEST_1 As Long=156
Public Const reg_DRE_TEST_2 As Long=157
Public Const reg_DAC_TEST_1 As Long=159
Public Const reg_DAC_TEST_2 As Long=160
Public Const reg_TEST_BIAS_0 As Long=164
Public Const reg_TEST_BIAS_1 As Long=165
Public Const reg_TEST_BIAS_2 As Long=166
Public Const reg_TEST_PDM As Long=168
Public Const reg_TEST_ICC_CONTROL As Long=169
Public Const reg_TEST_ATB As Long=170
Public Const reg_TEST_BOOST_0 As Long=171
Public Const reg_TEST_BOOST_00 As Long=172
Public Const reg_TEST_SPK_0 As Long=173
Public Const reg_TEST_SPK_1 As Long=174
Public Const reg_TEST_SPK_SM_OVERRIDE As Long=175
Public Const reg_TEST_SPK_SM_OVERRIDE_VALUE As Long=176
Public Const reg_TEST_MDLL_0 As Long=177
Public Const reg_TEST_MDLL_CNTL As Long=178
Public Const reg_TEST_MDLL_EN As Long=179
Public Const reg_TEST_MDLL_BYPASS As Long=180
Public Const reg_OSC_TEST As Long=181
Public Const reg_TEST_DIGITAL_DFT_1 As Long=183
Public Const reg_TEST_DIGITAL_DFT_2 As Long=184
Public Const reg_TEST_DIGITAL_DFT_3 As Long=185
Public Const reg_TEST_DIGITAL_DFT_4 As Long=186
Public Const reg_TEST_BROWNOUT As Long=187
Public Const reg_TEST_BROWNOUT_INPUT_OVERRIDE As Long=188
Public Const reg_TEST_BROWNOUT_INPUT_OVERRIDE_ENABLE As Long=189
Public Const reg_TEST_POINT_OUTPUT_IRQB As Long=190
Public Const reg_TEST_POINT_OUTPUT_BCLK As Long=191
Public Const reg_TEST_POINT_OUTPUT_LRCLK As Long=192
Public Const reg_TEST_POINT_OUTPUT_DOUT As Long=193
Public Const reg_TEST_POINT_OUTPUT_ICC As Long=194
Public Const reg_TEST_VOH As Long=195
Public Const reg_TEST_TVI_MASK_8 As Long=196
Public Const reg_TEST_TVI_MASK_7_TO_0 As Long=197
Public Const reg_TEST_AUTHENTICATION_OTP_BITS As Long=198
Public Const reg_TEST_DSP_AND_DRE_OTP As Long=199
Public Const reg_TEST_OSC_TRIM As Long=200
Public Const reg_TEST_SPK_2 As Long=201
Public Const reg_TEST_SPK_OFFSET_TRIM As Long=202
Public Const reg_TEST_BOOST_1 As Long=203
Public Const reg_TEST_BOOST_2 As Long=204
Public Const reg_TEST_BOOST_3 As Long=205
Public Const reg_TEST_BOOST_4 As Long=206
Public Const reg_TEST_BOOST_5 As Long=207
Public Const reg_TEST_BOOST_6 As Long=208
Public Const reg_TEST_BOOST_7 As Long=209
Public Const reg_TEST_BOOST_9 As Long=210
Public Const reg_TEST_BOOST_10 As Long=211
Public Const reg_TEST_BIAS_3 As Long=212
Public Const reg_TEST_BIAS_ICGM_TRIM As Long=213
Public Const reg_TEST_BIAS_BANDGAP_TRIM As Long=214
Public Const reg_TEST_IV_FE_I_TRIMF As Long=215
Public Const reg_TEST_IV_FE_I_TRIMC As Long=216
Public Const reg_TEST_IV_FE_V_TRIM As Long=217
Public Const reg_TEST_IVADC_XTALK_COEFFICIENT__OTP As Long=218
Public Const reg_TEST_IVADC_TEMP_COEFFICIENT_A_OTP_ As Long=219
Public Const reg_TEST_IVADC_TEMP_COEFFICIENT_B_OTP_ As Long=220
Public Const reg_TEST_MEAS_ADC_GAIN_TRIM As Long=221
Public Const reg_TEST_MEAS_ADC_OFFSET_TRIM As Long=222
Public Const reg_TEST_MEAS_ADC_TEMP_TRIM As Long=223
Public Const reg_TEST_OTP_ADDRESS_MSB As Long=224
Public Const reg_TEST_OTP_ADDRESS_LSB As Long=225
Public Const reg_TEST_OTP_WRITE_DATA_MSB As Long=226
Public Const reg_TEST_OTP_WRITE_DATA_LSB As Long=227
Public Const reg_TEST_OTP_READ_DATA_MSB As Long=228
Public Const reg_TEST_OTP_READ_DATA_LSB As Long=229
Public Const reg_TEST_OTP_SIDENSE_MREF_MSB As Long=230
Public Const reg_TEST_OTP_SIDENSE_MREF_LSB As Long=231
Public Const reg_TEST_OTP_READ_CTRL As Long=232
Public Const reg_TEST_OTP_PROGRAM_CTRL As Long=233
Public Const reg_AUTHENTICATION_KEY_0 As Long=234
Public Const reg_AUTHENTICATION_KEY_1 As Long=235
Public Const reg_AUTHENTICATION_KEY_2 As Long=236
Public Const reg_AUTHENTICATION_KEY_3 As Long=237
Public Const reg_AUTHENTICATION_ENABLE As Long=238
Public Const reg_AUTHENTICATION_RESULT_0 As Long=239
Public Const reg_AUTHENTICATION_RESULT_1 As Long=240
Public Const reg_AUTHENTICATION_RESULT_2 As Long=241
Public Const reg_AUTHENTICATION_RESULT_3 As Long=242
Public Const reg_AUTHENTICATION_RESULT_4 As Long=243
Public Const reg_AUTHENTICATION_RESULT_5 As Long=244
Public Const reg_AUTHENTICATION_RESULT_6 As Long=245
Public Const reg_AUTHENTICATION_RESULT_7 As Long=246
Public Const reg_AUTHENTICATION_RESULT_8 As Long=247
Public Const reg_AUTHENTICATION_RESULT_9 As Long=248
Public Const reg_AUTHENTICATION_RESULT_10 As Long=249
Public Const reg_AUTHENTICATION_RESULT_11 As Long=250
Public Const reg_AUTHENTICATION_RESULT_12 As Long=251
Public Const reg_AUTHENTICATION_RESULT_13 As Long=252
Public Const reg_AUTHENTICATION_RESULT_14 As Long=253
Public Const reg_AUTHENTICATION_RESULT_15 As Long=254
Public Const reg_GLOBAL_ENABLE As Long=255
Public Const reg_SOFTWARE_RESET As Long=256
Public Const reg_REV_ID As Long=511
End Module
