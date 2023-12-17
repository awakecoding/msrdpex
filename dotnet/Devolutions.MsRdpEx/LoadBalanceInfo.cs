﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

// NOTE: this is actually IMsRdpClientAdvancedSettings and part of the TLB - no need to duplicate it here

namespace MSTSCLib
{
    [GeneratedComInterface]
    [Guid("3C65B4AB-12B3-465B-ACD4-B8DAD3BFF9E2")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public unsafe partial interface IMsRdpClientAdvancedSettingsLB // : IMsTscAdvancedSettings
    {
        void GetTypeInfoCount( // virtual HRESULT STDMETHODCALLTYPE GetTypeInfoCount
            out int count); // /* [out] */ __RPC__out UINT *pctinfo

        void GetTypeInfo( // virtual HRESULT STDMETHODCALLTYPE GetTypeInfo
            int index, // /* [in] */ UINT iTInfo
            int language, // /* [in] */ LCID lcid
            [MarshalAs(UnmanagedType.Interface)] out object type); // /* [out] */ __RPC__deref_out_opt ITypeInfo **ppTInfo

        void GetIDsOfNames( // virtual HRESULT STDMETHODCALLTYPE GetIDsOfNames
            in Guid riid, // /* [in] */ __RPC__in REFIID riid
            nint* rgszNames, // /* [size_is][in] */ __RPC__in_ecount_full(cNames) LPOLESTR *rgszNames
            int cNames, // /* [range][in] */ __RPC__in_range(0,16384) UINT cNames
            int lcid, // /* [in] */ LCID lcid
            int* rgDispId); // /* [size_is][out] */ __RPC__out_ecount_full(cNames) DISPID* rgDispId

        void Invoke( // virtual /* [local] */ HRESULT STDMETHODCALLTYPE Invoke
            int dispIdMember, // /* [annotation][in] */ _In_ DISPID dispIdMember
            in Guid riid, // /* [annotation][in] */ _In_ REFIID riid
            int lcid, // /* [annotation][in] */ _In_ LCID lcid
            IDispatchFlags wFlags, // /* [annotation][in] */ _In_ WORD wFlags
            nint pDispParams, // /* [annotation][out][in] */ _In_ DISPPARAMS *pDispParams
            nint pVarResult, // /* [annotation][out] */ _Out_opt_ VARIANT *pVarResult
            nint pExcepInfo, // /* [annotation][out] */ _Out_opt_ EXCEPINFO *pExcepInfo
            int* puArgErr); // /* [annotation][out] */ _Out_opt_ UINT *puArgErr

        void put_Compress();
        void get_Compress();
        void put_BitmapPeristence();
        void get_BitmapPeristence();
        void put_allowBackgroundInput();
        void get_allowBackgroundInput();
        void put_KeyBoardLayoutStr();
        void put_PluginDlls();
        void put_IconFile();
        void put_IconIndex();
        void put_ContainerHandledFullScreen();
        void get_ContainerHandledFullScreen();
        void put_DisableRdpdr();
        void get_DisableRdpdr();
        void put_SmoothScroll();
        void get_SmoothScroll();
        void put_AcceleratorPassthrough();
        void get_AcceleratorPassthrough();
        void put_ShadowBitmap();
        void get_ShadowBitmap();
        void put_TransportType();
        void get_TransportType();
        void put_SasSequence();
        void get_SasSequence();
        void put_EncryptionEnabled();
        void get_EncryptionEnabled();
        void put_DedicatedTerminal();
        void get_DedicatedTerminal();
        void put_RDPPort();
        void get_RDPPort();
        void put_EnableMouse();
        void get_EnableMouse();
        void put_DisableCtrlAltDel();
        void get_DisableCtrlAltDel();
        void put_EnableWindowsKey();
        void get_EnableWindowsKey();
        void put_DoubleClickDetect();
        void get_DoubleClickDetect();
        void put_MaximizeShell();
        void get_MaximizeShell();
        void put_HotKeyFullScreen();
        void get_HotKeyFullScreen();
        void put_HotKeyCtrlEsc();
        void get_HotKeyCtrlEsc();
        void put_HotKeyAltEsc();
        void get_HotKeyAltEsc();
        void put_HotKeyAltTab();
        void get_HotKeyAltTab();
        void put_HotKeyAltShiftTab();
        void get_HotKeyAltShiftTab();
        void put_HotKeyAltSpace();
        void get_HotKeyAltSpace();
        void put_HotKeyCtrlAltDel();
        void get_HotKeyCtrlAltDel();
        void put_orderDrawThreshold();
        void get_orderDrawThreshold();
        void put_BitmapCacheSize();
        void get_BitmapCacheSize();
        void put_BitmapVirtualCacheSize();
        void get_BitmapVirtualCacheSize();
        void put_ScaleBitmapCachesByBPP();
        void get_ScaleBitmapCachesByBPP();
        void put_NumBitmapCaches();
        void get_NumBitmapCaches();
        void put_CachePersistenceActive();
        void get_CachePersistenceActive();
        void put_PersistCacheDirectory();
        void put_brushSupportLevel();
        void get_brushSupportLevel();
        void put_minInputSendInterval();
        void get_minInputSendInterval();
        void put_InputEventsAtOnce();
        void get_InputEventsAtOnce();
        void put_maxEventCount();
        void get_maxEventCount();
        void put_keepAliveInterval();
        void get_keepAliveInterval();
        void put_shutdownTimeout();
        void get_shutdownTimeout();
        void put_overallConnectionTimeout();
        void get_overallConnectionTimeout();
        void put_singleConnectionTimeout();
        void get_singleConnectionTimeout();
        void put_KeyboardType();
        void get_KeyboardType();
        void put_KeyboardSubType();
        void get_KeyboardSubType();
        void put_KeyboardFunctionKey();
        void get_KeyboardFunctionKey();
        void put_WinceFixedPalette();
        void get_WinceFixedPalette();
        void put_ConnectToServerConsole();
        void get_ConnectToServerConsole();
        void put_BitmapPersistence();
        void get_BitmapPersistence();
        void put_MinutesToIdleTimeout();
        void get_MinutesToIdleTimeout();
        void put_SmartSizing();
        void get_SmartSizing();
        void put_RdpdrLocalPrintingDocName();
        void get_RdpdrLocalPrintingDocName();
        void put_RdpdrClipCleanTempDirString();
        void get_RdpdrClipCleanTempDirString();
        void put_RdpdrClipPasteInfoString();
        void get_RdpdrClipPasteInfoString();
        void put_ClearTextPassword();
        void put_DisplayConnectionBar();
        void get_DisplayConnectionBar();
        void put_PinConnectionBar();
        void get_PinConnectionBar();
        void put_GrabFocusOnConnect();
        void get_GrabFocusOnConnect();

        [DispId(190)]
        void SetLoadBalanceInfo(IntPtr value);

        [DispId(190)]
        IntPtr GetLoadBalanceInfo();

        void put_RedirectDrives();
        void get_RedirectDrives();
        void put_RedirectPrinters();
        void get_RedirectPrinters();
        void put_RedirectPorts();
        void get_RedirectPorts();
        void put_RedirectSmartCards();
        void get_RedirectSmartCards();
        void put_BitmapVirtualCache16BppSize();
        void get_BitmapVirtualCache16BppSize();
        void put_BitmapVirtualCache24BppSize();
        void get_BitmapVirtualCache24BppSize();
        void put_PerformanceFlags();
        void get_PerformanceFlags();
        void put_ConnectWithEndpoint();
        void put_NotifyTSPublicKey();
        void get_NotifyTSPublicKey();
        void get_CanAutoReconnect();
        void put_EnableAutoReconnect();
        void get_EnableAutoReconnect();
        void put_MaxReconnectAttempts();
        void get_MaxReconnectAttempts();
        void put_ConnectionBarShowMinimizeButton();
        void get_ConnectionBarShowMinimizeButton();
        void put_ConnectionBarShowRestoreButton();
        void get_ConnectionBarShowRestoreButton();
        void put_AuthenticationLevel();
        void get_AuthenticationLevel();
        void put_RedirectClipboard();
        void get_RedirectClipboard();
        void put_AudioRedirectionMode();
        void get_AudioRedirectionMode();
        void put_ConnectionBarShowPinButton();
        void get_ConnectionBarShowPinButton();
        void put_PublicMode();
        void get_PublicMode();
        void put_RedirectDevices();
        void get_RedirectDevices();
        void put_RedirectPOSDevices();
        void get_RedirectPOSDevices();
        void put_BitmapVirtualCache32BppSize();
        void get_BitmapVirtualCache32BppSize();
        void put_RelativeMouseMode();
        void get_RelativeMouseMode();
        void get_AuthenticationServiceClass();
        void put_AuthenticationServiceClass();
        void get_PCB();
        void put_PCB();
        void put_HotKeyFocusReleaseLeft();
        void get_HotKeyFocusReleaseLeft();
        void put_HotKeyFocusReleaseRight();
        void get_HotKeyFocusReleaseRight();
        void put_EnableCredSspSupport();
        void get_EnableCredSspSupport();
        void get_AuthenticationType();
        void put_ConnectToAdministerServer();
        void get_ConnectToAdministerServer();
        void put_AudioCaptureRedirectionMode();
        void get_AudioCaptureRedirectionMode();
        void put_VideoPlaybackMode();
        void get_VideoPlaybackMode();
        void put_EnableSuperPan();
        void get_EnableSuperPan();
        void put_SuperPanAccelerationFactor();
        void get_SuperPanAccelerationFactor();
        void put_NegotiateSecurityLayer();
        void get_NegotiateSecurityLayer();
        void put_AudioQualityMode();
        void get_AudioQualityMode();
        void put_RedirectDirectX();
        void get_RedirectDirectX();
        void put_NetworkConnectionType();
        void get_NetworkConnectionType();
        void put_BandwidthDetection();
        void get_BandwidthDetection();
        void put_ClientProtocolSpec();
        void get_ClientProtocolSpec();
        void put_HotKeyFocusReleaseUp();
        void get_HotKeyFocusReleaseUp();
        void put_HotKeyFocusReleaseDown();
        void get_HotKeyFocusReleaseDown();
    }
}
