﻿using SimpleIdServer.Mobile.Stores;

namespace SimpleIdServer.Mobile;

public partial class App : Application
{
    private readonly CredentialListState _credentialListState;
	private readonly OtpListState _otpListState;
    public static MobileDatabase _database;

	public static MobileDatabase Database
	{
		get
		{
			if (_database != null) return _database;
			_database = new MobileDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "sidDB.db3"));
			return _database;
		}
	}

	public App(CredentialListState credentialListState, OtpListState otpListState)
	{
		InitializeComponent();
		_credentialListState = credentialListState;
        _otpListState = otpListState;
        MainPage = new AppShell();
    }

    protected override async void OnStart()
    {
        base.OnStart();
		await _otpListState.Load();
		await _credentialListState.Load();

    }
}
