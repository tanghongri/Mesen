#pragma once
#include "stdafx.h"
#include <deque>
#include "../Utilities/SimpleLock.h"
#include "DebuggerTypes.h"

class Debugger;

enum class CallbackType
{
	CpuRead = 0,
	CpuWrite = 1,
	CpuExec = 2,
	PpuRead = 3,
	PpuWrite = 4
};

class ScriptingContext
{
private:
	//Must be static to be thread-safe when switching game
	//UI updates all script windows in a single thread, so this is safe
	static string _log;

	std::deque<string> _logRows;
	SimpleLock _logLock;
	bool _inStartFrameEvent = false;
	bool _inExecOpEvent = false;

	std::unordered_map<int32_t, string> _saveSlotData;
	int32_t _saveSlot = -1;
	int32_t _loadSlot = -1;

protected:
	vector<int> _callbacks[5][0x10000];
	vector<int> _eventCallbacks[7];

	virtual void InternalCallMemoryCallback(uint16_t addr, uint8_t &value, CallbackType type) = 0;
	virtual int InternalCallEventCallback(EventType type) = 0;

public:
	virtual bool LoadScript(string scriptContent, Debugger* debugger) = 0;

	void Log(string message);
	const char* GetLog();

	void RequestSaveState(int slot);
	bool RequestLoadState(int slot);
	void SaveState();
	bool LoadState();
	string GetSavestateData(int slot);
	void ClearSavestateData(int slot);
	bool ProcessSavestate();

	void CallMemoryCallback(uint16_t addr, uint8_t &value, CallbackType type);
	int CallEventCallback(EventType type);
	bool CheckInStartFrameEvent();
	
	void RegisterMemoryCallback(CallbackType type, int startAddr, int endAddr, int reference);
	void UnregisterMemoryCallback(CallbackType type, int startAddr, int endAddr, int reference);
	void RegisterEventCallback(EventType type, int reference);
	void UnregisterEventCallback(EventType type, int reference);
};