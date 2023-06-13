using mentoring_system.Abstraction;
using mentoring_system.model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Protection.PlayReady;

namespace mentoring_system.Implementation
{
    internal class MenteeFunctionality : IMenteeFunctionality
    {
        private readonly ApiClient _apiClient;

        public MenteeFunctionality(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task AddMenteeData(string url, Mentee menteeData)
        {
            try
            {
                HttpResponseMessage response = await _apiClient.PostAsJsonAsync(url, menteeData);
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine("Data mentee baru berhasil ditambahkan");
                }
                else
                {
                    Debug.WriteLine("Gagal menambahkan data mentee baru");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Terjadi kesalahan saat menambahkan data mentee baru: " + ex.Message);
            }
        }

        public async Task<Mentee> AuthenticateUser(string username, string password)
        {
            try
            {
                HttpResponseMessage response = await _apiClient.GetAsync("http://178.128.215.35:5132/api/mentee");

                if (response != null && response.IsSuccessStatusCode)
                {
                    Mentee loggedInUser = null;
                    Mentee[] result = await response.Content.ReadFromJsonAsync<Mentee[]>();
                    Console.WriteLine(result);

                    foreach (Mentee mentee in result)
                    {
                        if (mentee.userName == username && mentee.password == password)
                        {
                            if (loggedInUser != null)
                            {
                                ShowMessageBox("Multiple users found with same credentials", "Login failed");
                                return null;
                            }
                            loggedInUser = mentee;
                        }
                    }

                    return loggedInUser;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Terjadi kesalahan saat mengotentikasi pengguna: " + ex.Message);
            }

            return null;
        }

        private static void ShowMessageBox(string message, string title)
        {
            Debug.WriteLine(title + ": " + message);
        }
    }
}
